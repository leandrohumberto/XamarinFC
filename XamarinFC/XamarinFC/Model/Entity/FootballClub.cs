using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace XamarinFC.Model.Entity
{
    [DataTable("FootballClub")]
    public class FootballClub
    {
        [Version]
        public string AzureVersion { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("anthem")]
        public string Anthem { get; set; }

        public override string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}
