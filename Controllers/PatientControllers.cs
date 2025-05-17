using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet("GetPatientInformation/{patientId}")]
        public IActionResult GetPatientInformation(int patientId)
        {
            var patient = new Patient
            {
                // Id = patientId,
                // FirstName = "Maneesh",
                // LastName = "Ch",
                // DateOfBirth = new DateTime(2000, 1, 1),
                // Insurance = "Medi",
                // Phone = 1234567890,
                // StreetAddress = "123 Main St",
                // City = "CityX",
                // State = "StateY",
                // ZipCode = "12345",
                // Country = "US",
                // SelectGender = "Male",
                // MedicalHistory = new List<string> { "Diabetes" },
                // MaritalStatus = "Single"
            };

            return Ok(patient);
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Patient patient)
        {
            // Log or save patient details here
            // Console.WriteLine($"Received patient: {patient.FirstName} {patient.LastName}");

            return Ok(new {patient });
        }
    }
}
