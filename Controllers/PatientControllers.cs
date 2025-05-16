using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PatientController: ControllerBase
{
    [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    Patient patient = new Patient
        {
            Id = patientId,
            Name = "Sushanth",
            Age = 25,
            Diagnosis = "Hypertension"
        };
    return Ok(patient);
  }

  [HttpPost ("Register")]
  public IActionResult Register(Patient patient)
  {
    System.Console.WriteLine(patient.Id);
    return Ok(patient);
  }
  
}