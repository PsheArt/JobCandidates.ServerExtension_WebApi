using AssignmentService.Models;
using CandidateService.Models;
using InterviewService.Models;

namespace InterviewService.Service
{
    public interface IInterviewService
    {
        List<InterviewModel> Interviews();

        InterviewModel GetInterview(Guid Id);
        AssignmentModel GetAssignments(Guid Id);
        string AddInterview(InterviewModel interview);
        string UpdateInterview(InterviewModel interview);
        string DeleteInterview(Guid Id);
        string GetInteviewer(Guid Id);
        List<InterviewModel> OrderInterviews(string parameter);
        CandidateModels GetCandidate(Guid Id);
        string GetDepartment(Guid Id);
        string GetPosition(Guid Id);
        string GetStatus(Guid Id);


    }
}
