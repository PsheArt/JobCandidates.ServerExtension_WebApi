using AssignmentService.Models;
using AssignmentService.Service;
using CandidateService.Models;
using InterviewService.Models;
using System.Reflection.Metadata.Ecma335;

namespace InterviewService.Service
{
    public class InterviewService : IInterviewService
    {
        List<InterviewModel> interviews = new List<InterviewModel>();
        IAssignmentService assignmentService { get; set; }
        public InterviewService(IAssignmentService assignmentService) 
        {
            this.assignmentService = assignmentService; 
        }

        public List<InterviewModel> Interviews() => interviews;

        public InterviewModel GetInterview(Guid Id) => interviews.FirstOrDefault(x => x.Id == Id);

        public AssignmentModel GetAssignments(Guid Id)
        {
           var interview = GetInterview(Id);
            return assignmentService.GetAssignment(interview.Assignment.Id); 
        }

        public string AddInterview(InterviewModel interview)
        {
            string result = string.Empty;
            try
            {
                interviews.Add(interview);
                result = $"Добавлен новое интервью: {interview.Name}";
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string UpdateInterview(InterviewModel interview)
        {
            string result = string.Empty;
            try
            {
                var updateInterview = GetInterview(interview.Id);
                updateInterview = interview;
                interviews.Remove(interview);   
                interviews.Add(updateInterview);
                result = $"Обновлено интервью: {updateInterview.Name}";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public  string DeleteInterview(Guid Id)
        {
            string result = string.Empty;
            try
            {
                interviews.Remove(interviews.FirstOrDefault(x => x.Id == Id));
                result = "Интервью удалено";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string GetInteviewer(Guid Id)
        {
            string result = string.Empty;
            try
            {
                var interview = GetInterview(Id);
                result = interview.Interviewer;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public List<InterviewModel> OrderInterviews(string parameter)
        {
            if(parameter == "Name") return interviews.OrderBy(x => x.Name).ToList();
            if (parameter == "Task") return interviews.OrderBy(x=>x.Assignment.NameTask).ToList();
            if (parameter == "Interviewer") return interviews.OrderBy(x => x.Interviewer).ToList()
                    ;
            return interviews;  
        }
        public CandidateModels GetCandidate(Guid Id) => GetInterview(Id).Candidate;
        public string GetDepartment(Guid Id) => GetInterview(Id).Departmaent;
        public string GetPosition(Guid Id)=> GetInterview(Id).Position;
        public string GetStatus(Guid Id) => GetInterview(Id).Status;



    }
}
