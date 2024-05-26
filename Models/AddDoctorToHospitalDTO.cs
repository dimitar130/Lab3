namespace Lab3.Models
{
    public class AddDoctorToHospitalDTO
    {
        public AddDoctorToHospitalDTO() {
            this.hospitals = new List<Hospital>();
        }
        public  List<Hospital> hospitals { get; set; }
        public int doctorId { get; set; }
        public int hospitalId { get; set; }
    }
}
