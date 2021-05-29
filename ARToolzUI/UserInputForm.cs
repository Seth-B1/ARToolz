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
        //string providerDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "\localstorage\providerdata.json";
        string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";

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
                File.Create(providerDataFile);   
            }
        }

        private void ReloadProviderListUI()
        {
            System.Threading.Thread.Sleep(3000);
            providerFileContent = File.ReadAllText(providerDataFile);
            var json = JObject.Parse(providerFileContent);
                     
            ProviderListBox.Items.Add(json.SelectToken("companyName").Value<string>());

            for (int i = 0; i < json.Count; i++)
            {
                Provider newProvider = new Provider();
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

            PdfReader pdfReader = new PdfReader(pdfTemplate);

            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));

            AcroFields pdfFormFields = pdfStamper.AcroFields;

            pdfFormFields.SetField("form1[0].#subform[0].PatientControlNo[0]", RunNumberValue.Text);
            pdfFormFields.SetField("form1[0].#subform[0].AddressLine1[1]", "123 Street ST");
            pdfStamper.FormFlattening = true;
            pdfStamper.Close();

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
    }
}
