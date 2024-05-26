using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Patient
    {
        public Patient() {
            this.Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Кодот на пациентот треба да биде цел број составен од точно 5 цифри")]
        [Display(Name = "Код на пациентот")]
        public int PatientCode { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
