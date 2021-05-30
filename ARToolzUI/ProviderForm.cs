using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


namespace ARToolzUI
{
    public partial class ProviderForm : Form
    {

        public static Action UpdateProviderListBoxUI;
        string json;
        List<Provider> newProvidersList = new List<Provider>();
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void ProviderSubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateProviderForm())
            {
                Provider newProvider = new Provider();
                newProvider.companyName = ProviderCompanyNameField.Text;
                newProvider.taxID = TaxIDField.Text;
                newProvider.NPI = NPIField.Text;
                newProvider.addressBox1 = ProviderAddressLine1Field.Text;
                newProvider.addressBox2 = ProviderAddressLine2Field.Text;
                newProvider.city = ProviderCityField.Text;
                newProvider.state = ProviderStateField.Text;
                newProvider.zipcode = ProviderZipCodeField.Text;

                AddNewProviderToCollection(newProvider);
                

            }
            UpdateProviderListBoxUI();
            Close();
        }

        private void AddNewProviderToCollection(Provider newProvider)
        {
            string providerDataFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\localstorage\providerdata.json";
            //string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";
            if (new FileInfo(providerDataFile).Length == 0)
            {
                
                json = JsonConvert.SerializeObject(newProvidersList, Formatting.Indented);

                System.Threading.Thread.Sleep(7000);
                System.IO.File.WriteAllText(providerDataFile, json);
                return;
            }
            json = JsonConvert.SerializeObject(providerDataFile, Formatting.Indented);
            List<Provider> savedProvidersList = GetDeserializedProviderList(File.ReadAllText(providerDataFile));
            savedProvidersList.Add(newProvider);

            json = JsonConvert.SerializeObject(savedProvidersList, Formatting.Indented);
            System.Threading.Thread.Sleep(1000);
            System.IO.File.WriteAllText(providerDataFile, json);
            
        }

        private List<Provider> GetDeserializedProviderList(string _providerDataFile)
        {
            List<Provider> newProviderList = new List<Provider>();

            newProviderList = JsonConvert.DeserializeObject<List<Provider>>(_providerDataFile);

            return newProviderList;
        }

        private bool ValidateProviderForm()
        {
            return true;
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
    }
}
