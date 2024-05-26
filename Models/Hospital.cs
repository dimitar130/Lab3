using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageURL { get; set; }
        public string Phone { get; set; }
    }
}
