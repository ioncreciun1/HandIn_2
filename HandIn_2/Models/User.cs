using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace HandIn_2.Models
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}