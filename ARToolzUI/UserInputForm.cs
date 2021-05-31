using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;

namespace ARToolzUI
{
    public partial class UserInputForm : Form
    {
        string providerFileContent;
        List<Provider> providerList;
        string providerDataFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage\providerdata.json";


        public UserInputForm()
        {
            ProviderForm.UpdateProviderListBoxUI += ReloadProviderListUI;

            InitializeComponent();
            InitializeProviderList();
            //ListFieldNames();
        }

        private void InitializeProviderList()
        {
            if (!File.Exists(providerDataFile))
            {
                string jsonNullProvider = @"[
{
    'companyName': 'null',
    'taxID': 'null',
    'NPI': 'null',
    'addressBox1': 'null',
    'addressBox2': 'null',
    'city': 'null',
    'state': 'null',
    'zipcode': 'null',
    'employeeID' : 'null'
  }
]";
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage");
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\results");
                using (FileStream fs = File.Create(providerDataFile))
                {
                    AddText(fs, jsonNullProvider);
                    fs.Close();
                }
                return;
            }

            else if (new FileInfo(providerDataFile).Length > 0) ReloadProviderListUI();
        }


        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void ReloadProviderListUI()
        {
            System.Threading.Thread.Sleep(1000);
            var json = File.ReadAllText(providerDataFile);

            providerList = JsonConvert.DeserializeObject<List<Provider>>(json);

            ProviderListBox.Items.Clear();
            foreach (Provider provider in providerList)
            {
                if (provider.companyName == "null") continue;

                ProviderListBox.Items.Add(provider.companyName);
            }


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                MessageBox.Show("Submission completed successfully.");
                TampaFillForm();
                VAFillForm();
                System.Threading.Thread.Sleep(2000);
                System.Diagnostics.Process.Start(@"explorer.exe", Path.GetDirectoryName(Application.ExecutablePath) + @"\results");

            }
            else
            {
                MessageBox.Show("Submission failed");
            }

        }

        private bool ValidateForm()
        {
            MessageBox.Show("Validating form");
            bool formStatus = true;
            if (RunNumberValue.Text.Length == 0)
            {
                formStatus = false;
            }

            return formStatus;
        }


        private void TampaFillForm()
        {
            string pdfTemplate = Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage\TampaFormTemplate.pdf";
            string newFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\results\TampaForm.pdf";
            Provider selectedProvider = GetSelectedProvider();
            PdfReader pdfReader = new PdfReader(pdfTemplate);


            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            //Tampa
            pdfFormFields.SetField("form1[0].#subform[0].PatientControlNo[0]", RunNumberValue.Text);
            pdfFormFields.SetField("form1[0].#subform[0].FromDate[0]", DOSField.Text);
            pdfFormFields.SetField("form1[0].#subform[0].ToDate[0]", DOSField.Text);
            pdfFormFields.SetField("form1[0].#subform[0].MemberID[0]", SSNField.Text);
            pdfFormFields.SetField("form1[0].#subform[0].TraceNumber[0]", ClaimNumberField.Text);///
            pdfFormFields.SetField("form1[0].#subform[0].FirstName[0]", FirstNameField.Text);
            pdfFormFields.SetField("form1[0].#subform[0].LastName[0]", LastNameField.Text);
            pdfFormFields.SetField("form1[0].#subform[0].MI[0]", MiddleNameField.Text);
           

            pdfFormFields.SetField("form1[0].#subform[0].TaxID[0]", selectedProvider.taxID);
            pdfFormFields.SetField("form1[0].#subform[0].NPI[0]", selectedProvider.NPI);
            pdfFormFields.SetField("form1[0].#subform[0].ProviderName[0]", selectedProvider.companyName);
            pdfFormFields.SetField("form1[0].#subform[0].AddressLine1[1]", selectedProvider.addressBox1);
            pdfFormFields.SetField("form1[0].#subform[0].AddressLine1[0]", selectedProvider.addressBox2);
            pdfFormFields.SetField("form1[0].#subform[0].AddressLine1[2]", selectedProvider.city);
            pdfFormFields.SetField("form1[0].#subform[0].AddressLine1[3]", selectedProvider.state);
            pdfFormFields.SetField("form1[0].#subform[0].NPI[1]", selectedProvider.zipcode);
            pdfFormFields.SetField("form1[0].#subform[0].FromDate[1]", System.DateTime.Today.ToShortDateString());




            pdfStamper.FormFlattening = true;
            pdfStamper.Close();

        }
        private void VAFillForm()
        {
            string pdfTemplate = Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage\VAFormTemplate.pdf";
            string newFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\results\VAForm.pdf";
            Provider selectedProvider = GetSelectedProvider();
            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;


            pdfFormFields.SetField("vha10583[0].#subform[0].Inst14[0]", "aa");
            pdfFormFields.SetField("vha10583[0].#subform[0].vet_address[0]", AddressLine1Field.Text + " " + AddressLine2Field.Text + ", " + CityField.Text + " " + StateField.Text + " " + ZipcodeField.Text);
            pdfFormFields.SetField("vha10583[0].#subform[0].CLAIM1[0]", "cc");
            pdfFormFields.SetField("vha10583[0].#subform[0].Vet_name[0]", (LastNameField.Text + "," + FirstNameField.Text + " " + MiddleNameField.Text));
            pdfFormFields.SetField("vha10583[0].#subform[0].SSN2[0]", selectedProvider.employeeID);
            pdfFormFields.SetField("vha10583[0].#subform[0].Inst11[0]", "ff");
//            pdfFormFields.SetField("vha10583[0].#subform[0].signature1[0]", "gg");
            pdfFormFields.SetField("vha10583[0].#subform[0].SSN1[0]", SSNField.Text);
            pdfFormFields.SetField("vha10583[0].#subform[0].DISAPPROVED[0]", "ii");
            pdfFormFields.SetField("vha10583[0].#subform[0].Inst15a[0]", "kk");
            pdfFormFields.SetField("vha10583[0].#subform[0].CLAIM2[0]", "LL");
            pdfFormFields.SetField("vha10583[0].#subform[0].statement[0]", DescriptionField.Text);
//            pdfFormFields.SetField("vha10583[0].#subform[0].signature2[0]", "nn");
 //           pdfFormFields.SetField("vha10583[0].#subform[0].date1[0]", "pp");
            pdfFormFields.SetField("vha10583[0].#subform[0].Inst15b[0]", "qq");
            pdfFormFields.SetField("vha10583[0].#subform[0].APPROVED[0]", "ss");
            pdfFormFields.SetField("vha10583[0].#subform[0].claim_num[0]", ClaimNumberField.Text);
            pdfFormFields.SetField("vha10583[0].#subform[0].name_address[0]", selectedProvider.companyName + ", " + selectedProvider.addressBox1 + " " + selectedProvider.addressBox2 + ", " + selectedProvider.city + " " + selectedProvider.state + ", " + selectedProvider.zipcode);
            pdfFormFields.SetField("vha10583[0].#subform[0].amount[0]", BilledAmountField.Text);
            pdfFormFields.SetField("vha10583[0].#subform[0].date2[0]", "XXX");


            pdfStamper.FormFlattening = true;
            pdfStamper.Close();
        }


        private Provider GetSelectedProvider()
        {
            string listboxSelectedProvider = ProviderListBox.GetItemText(ProviderListBox.SelectedItem);

            foreach (Provider provider in providerList)
            {
                if (provider.companyName == listboxSelectedProvider)
                {
                    MessageBox.Show(provider.companyName + " was selected - filling out their data now");
                    return provider;
                }
            }
            return null;


        }


        ///Method only used for pulling PDF fields

        private void ListFieldNames()
        {
            string pdfTemplate = @"C:\Users\jakob\source\repos\ARToolzSolution\ARToolzUI\resources\VAForm.pdf";

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            StringBuilder sb = new StringBuilder();



            foreach (var de in pdfReader.AcroFields.Fields.Keys)
            {
                sb.Append(de + Environment.NewLine);
            }

            ///Uncomment when you need to parse a pdf
            //pdfTextBox.Text = sb.ToString();
            //pdfTextBox.SelectionStart = 0;
        }

        private void ProviderButton_Add_Click(object sender, EventArgs e)
        {
            ProviderForm providerFormWindow = new ProviderForm();
            providerFormWindow.Show();

        }
        public static bool IsFileReady(string filename)
        {
            try
            {
                using (FileStream inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                    return inputStream.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ProviderButton_Remove_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(providerDataFile, Formatting.Indented);
            List<Provider> savedProvidersList = GetDeserializedProviderList(File.ReadAllText(providerDataFile));
            
            foreach (Provider provider in savedProvidersList.ToList())
            {
                if (provider.companyName == ProviderListBox.SelectedItem.ToString())
                {
                    savedProvidersList.Remove(provider);
                }
            }

            json = JsonConvert.SerializeObject(savedProvidersList, Formatting.Indented);
            System.Threading.Thread.Sleep(500);
            System.IO.File.WriteAllText(providerDataFile, json);
            ReloadProviderListUI();
        }

        private List<Provider> GetDeserializedProviderList(string _providerDataFile)
        {
            List<Provider> newProviderList = new List<Provider>();

            newProviderList = JsonConvert.DeserializeObject<List<Provider>>(_providerDataFile);

            return newProviderList;
        }
    }
    }
