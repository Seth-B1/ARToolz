using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace ARToolzUI
{
   class ProviderCollection
    {
        /*public ProviderCollection()
        {
            {
                providers = new List<Provider>();
            }
        }*/
        [JsonProperty("providers")]
        public List<Provider> providers { get; set;}


    }
}
