namespace PatientRegistrationService.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string? Insurance { get; set; }

        public long Phone { get; set; }

        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }

        public string? SelectGender { get; set; }

        public List<string>? MedicalHistory { get; set; }

        public string? MaritalStatus { get; set; }
    }
}
