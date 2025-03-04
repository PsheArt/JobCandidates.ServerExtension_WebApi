﻿using AssignmentService.Models;
using CandidateService.Models;

namespace InterviewService.Models
{
    public class InterviewModel
    {
        public Guid Id { get; set; }   
        public string Name { get; set; }
        public string Description { get; set; }
        public AssignmentModel Assignment { get; set; }
        public CandidateModels Candidate { get; set; }
        public string Interviewer { get; set;   }
        public string Departmaent { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string HeadOfDepartment { get; set; }


    }
}
