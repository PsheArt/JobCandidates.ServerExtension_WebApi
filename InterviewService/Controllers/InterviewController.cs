﻿using CandidateService.Service;
using InterviewService.Service;
using Microsoft.AspNetCore.Mvc;

namespace InterviewService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController: ControllerBase
    {
        IInterviewService InterviewService { get; set; }
        public InterviewController(IInterviewService interviewService)
        {
            this.InterviewService = interviewService;
        }
        [HttpGet("GetInterviews")]
        public IActionResult GetInterviews() => Ok(InterviewService.Interviews());

        [HttpGet("GetInterview_{Id}")]
        public IActionResult GetInterview(Guid Id) => Ok(InterviewService.GetInterview(Id));

        [HttpGet("GetInterviewer_{Id}")]
        public IActionResult GetInterviewer(Guid Id) => Ok(InterviewService.GetInteviewer(Id));

        [HttpGet("GetHeadOfDepartment_{Id}")]
        public IActionResult GetHeadOfDepartment(Guid Id) => Ok(InterviewService.GetHeadOfDepartment(Id));

        [HttpGet("GetDepartment_{Id}")]
        public IActionResult GetDepartment(Guid Id) => Ok(InterviewService.GetDepartment(Id));
        
    }
}
