using C1_3_webAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace C1_3_webAPI.Models
{
    public class Pulishers
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
