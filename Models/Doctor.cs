using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Doctor
    {
        public Doctor() { 
            this.Patients = new List<Patient>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
