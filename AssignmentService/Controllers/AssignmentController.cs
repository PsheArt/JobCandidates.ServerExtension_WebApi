using AssignmentService.Models;
using AssignmentService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        IAssignmentService AssignmentService { get; set; }
        public AssignmentController(IAssignmentService assignmentService)
        {
            this.AssignmentService = assignmentService;
        }

        [HttpGet("get_{Id}")]
        public IActionResult GetAssignment(Guid Id)
        {
            return Ok(AssignmentService.GetAssignment(Id));
        }
        [HttpPost("add_assignment")]
        public IActionResult AddAssignment([FromBody] AssignmentModel assignment)
        {
            return Ok(AssignmentService.AddAssignment(assignment));
        }
        [HttpGet("get_all")]
        public IActionResult GetAll(){ return Ok(AssignmentService.GetAll()); }

        [HttpPost("update_assignment")]
        public IActionResult UpdateAssignment([FromBody] AssignmentModel assignmetnt) { return Ok(AssignmentService.UpdateAssignment(assignmetnt)); }
        [HttpPost("delete_assignment{id}")]
        public IActionResult DeleteAssignment(Guid Id) { return Ok(AssignmentService.RemoveAssignment(Id)); }    
        
    }
}
