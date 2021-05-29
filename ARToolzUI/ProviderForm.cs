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

                AddNewProviderToCollection(newProvider);
                

            }
            //UpdateProviderListBoxUI();
            Close();
        }

        private void AddNewProviderToCollection(Provider newProvider)
        {
            //string providerDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "\localstorage\providerdata.json";
            string providerDataFile = @"C:\Users\jakob\Secret\providerdatatest.json";
            if (new FileInfo(providerDataFile).Length == 0)
            {
                newProvidersList.Add(newProvider);
                json = JsonConvert.SerializeObject(newProvidersList, Formatting.Indented);

                System.Threading.Thread.Sleep(1500);
                System.IO.File.WriteAllText(providerDataFile, json);
                return;
            }
            json = JsonConvert.SerializeObject(providerDataFile, Formatting.Indented);
            List<Provider> savedProvidersList = GetDeserializedProviderList(File.ReadAllText(providerDataFile));
            savedProvidersList.Add(newProvider);

            foreach (Provider provider in savedProvidersList)
            {
                MessageBox.Show(provider.companyName);
            }

            json = JsonConvert.SerializeObject(savedProvidersList, Formatting.Indented);
            System.Threading.Thread.Sleep(1000);
            System.IO.File.WriteAllText(providerDataFile, json);

            System.Threading.Thread.Sleep(1000);
            
            //string newProviderResults = JsonConvert.SerializeObject(newProvider);            
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
    }
}
