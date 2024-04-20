using C1_3_webAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace C1_3_webAPI.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public List<Book_Author>? Book_Authors { get; set; }
    }
}