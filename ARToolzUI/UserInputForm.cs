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
namespace ARToolzUI
{
    public partial class UserInputForm : Form
    {
        string providerFileContent;
        List<Provider> providerList;
        string providerDataFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage\providerdata.json";
        //string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";

        public UserInputForm()
        {
            ProviderForm.UpdateProviderListBoxUI += ReloadProviderListUI;

            InitializeComponent();
            InitializeProviderList();
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
    'zipcode': 'null'
  }
]";
                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage");
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
                FillForm();
                System.Threading.Thread.Sleep(3000);
                System.Diagnostics.Process.Start(@"cmd.exe", @"/c C:\Users\jakob\Secret\TampaForm_new.pdf");
                
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

        private void FillForm()
        {
            string pdfTemplate = @"C:\Users\jakob\source\repos\ARToolzSolution\ARToolzUI\resources\TampaForm.pdf";
            string newFile = @"C:\Users\jakob\Secret\TampaForm_new.pdf";
            Provider selectedProvider = GetSelectedProvider();
            PdfReader pdfReader = new PdfReader(pdfTemplate);

            
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            //Tampa
            pdfFormFields.SetField("form1[0].#subform[0].PatientControlNo[0]", RunNumberValue.Text);
            pdfFormFields.SetField("form1[0].#subform[0].FromDate[0]", "From DOS");

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


        //Method only used for pulling PDF fields

        private void ListFieldNames()
        {
            string pdfTemplate = @"C:\Users\jakob\source\repos\ARToolzSolution\ARToolzUI\resources\TampaForm.pdf";

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            StringBuilder sb = new StringBuilder();



            foreach (var de in pdfReader.AcroFields.Fields.Keys)
            {
                sb.Append(de + Environment.NewLine);
            }

            pdfTextBox.Text = sb.ToString();
            pdfTextBox.SelectionStart = 0;
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

        private void UserInputForm_Load(object sender, EventArgs e)
        {

        }
    }
}
