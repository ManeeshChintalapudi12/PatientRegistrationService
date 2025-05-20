using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientRegistrationService.Models;
using PatientRegistrationService.Data;
using System.Threading.Tasks;

namespace PatientRegistrationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }

    
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Patient patient)
        {
            if (patient == null)
            {
                return BadRequest("Patient data is required.");
            }

            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Patient saved successfully", patient });
        }

        [HttpGet("GetPatientInformation/{patientId}")]
        public async Task<IActionResult> GetPatientInformation(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);

            if (patient == null)
            {
                return NotFound(new { message = "Patient not found" });
            }

            return Ok(patient);
        }
    }
}
