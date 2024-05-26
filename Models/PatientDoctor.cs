namespace Lab3.Models
{
    public class PatientDoctor
    {
        public PatientDoctor() {
            this.Patients = new List<Patient>();
        }
        public List<Patient> Patients { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
