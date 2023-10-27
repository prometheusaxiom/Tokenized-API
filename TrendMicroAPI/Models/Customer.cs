using Newtonsoft.Json;

namespace TrendMicroAPI.Models
{
    public class Customer
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Car { get; set; }
        public int Year_Model { get; set; }
    }
}
