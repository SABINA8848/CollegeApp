using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private static List<string> reports = new List<string>(); // Simulated in-memory storage

        // GET: api/reports
        [HttpGet]
        public IActionResult GetReports()
        {
            var userId = User.Identity?.Name;
            return Ok(new { User = userId, Reports = reports });
        }

        // GET: api/reports/{id}
        [HttpGet("{id}")]
        public IActionResult GetReportById(int id)
        {
            if (id < 0 || id >= reports.Count)
                return NotFound("Report not found.");

            return Ok(reports[id]);
        }

        // POST: api/reports
        [HttpPost]
        public IActionResult CreateReport([FromBody] string report)
        {
            if (string.IsNullOrEmpty(report))
                return BadRequest("Invalid report content.");

            reports.Add(report);
            return CreatedAtAction(nameof(GetReportById), new { id = reports.Count - 1 }, report);
        }

        // PUT: api/reports/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReport(int id, [FromBody] string updatedReport)
        {
            if (id < 0 || id >= reports.Count)
                return NotFound("Report not found.");

            if (string.IsNullOrEmpty(updatedReport))
                return BadRequest("Invalid report content.");

            reports[id] = updatedReport;
            return NoContent(); // 204 No Content
        }

        // DELETE: api/reports/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReport(int id)
        {
            if (id < 0 || id >= reports.Count)
                return NotFound("Report not found.");

            reports.RemoveAt(id);
            return NoContent();
        
    }
}
}
