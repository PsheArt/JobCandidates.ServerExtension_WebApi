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

        [HttpGet]
        public IActionResult GetCandidate(Guid Id)
        {
            return Ok(CandidateService.GetCandidate(Id));

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(CandidateService.GetCandidates());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CandidateModels candidate)
        {
            candidate.Id = Guid.NewGuid();
            CandidateService.AddCandidate(candidate);
            return CreatedAtAction(nameof(GetAll), new { id = candidate.Id }, candidate);
        }
        [HttpPost]
        public IActionResult UpdateCandidate([FromBody] CandidateModels candidate)
        {
            CandidateService.UpdateCandidate(candidate);
            return Ok(candidate);
        }

    }
}
