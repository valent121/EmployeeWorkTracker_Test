using EmployeeWorkTracker_Test.Data;
using EmployeeWorkTracker_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWorkTracker_Test.Controllers
{
    [Route("api/employees/reports")]
    public class ReportsController : ControllerBase
    {
        private readonly IEmployeeRepository _empRepository;

        public ReportsController(IEmployeeRepository empRepository)
        {
            _empRepository = empRepository;
        }
        [HttpGet]
        public async Task<ActionResult> Get(string employeeId)
        {
            try
            {
                if (employeeId == null)
                {
                    List<Report> reports = new List<Report>();
                    var employees = await _empRepository.GetAllEmployees();
                    foreach (var employee in employees)
                    {
                        Report report = await GetReport(employee);
                        reports.Add(report);
                    }
                    return Ok(reports);
                }
                else
                {
                    int employeeIdAsInt;
                    if (!Int32.TryParse(employeeId, out employeeIdAsInt))
                    {
                        return BadRequest("Invalid parameter value 'employeeID'. Value should be integer.");
                    }
                    var employee = await _empRepository.GetEmployee(employeeIdAsInt);
                    if (employee == null)
                    {
                        return BadRequest($"Cannot create report for non-exitent employee (ID {employeeIdAsInt})");
                    }
                    Report report = await GetReport(employee);
                    return Ok(report);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error processing request.");
            }
        }

        private async Task<Report> GetReport(Employee employee)
        {
            WorkingHours[] workingHours = await _empRepository.GetAllWorkingHours(employee.Id);
            TimeSpan workingHoursSum = TimeSpan.FromMinutes(workingHours.Select(w => w.Duration).Sum());
            return new Report() { Employee = employee, WorkingHours = String.Format($"{workingHoursSum.Hours}h {workingHoursSum.Minutes}m") };
        }
    }
}
