using CandidateService.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using CandidateService.Models;

namespace CandidateService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        ICandidateService CandidateService { get; set; }
        public CandidateController(ICandidateService candidateService)
        {
            this.CandidateService = candidateService;
        }

        [HttpGet("get_{Id}")]
        public IActionResult GetCandidate(string Id)
        {

            return Ok(CandidateService.GetCandidate(Guid.Parse(Id)));

        }
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(CandidateService.GetCandidates());
        }

        [HttpPost("new_candidate")]
        public IActionResult Create([FromBody] CandidateModels candidate)
        {
            candidate.Id = Guid.NewGuid();
            CandidateService.AddCandidate(candidate);
            return CreatedAtAction(nameof(GetAll), new { id = candidate.Id }, candidate);
        }
        [HttpPost("update_{id}")]
        public IActionResult UpdateCandidate([FromBody] CandidateModels candidate)
        {
            CandidateService.UpdateCandidate(candidate);
            return Ok(candidate);
        }

    }
}
