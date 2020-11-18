using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace HandIn_2.Models
{
    public class User
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("UserName")]
        public string userName { get; set; }
        [JsonPropertyName("Password")]
        public string password { get; set; }
    }
}