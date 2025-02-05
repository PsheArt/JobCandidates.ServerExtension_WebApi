using InterviewService.Models;
using System.Reflection.Metadata.Ecma335;

namespace InterviewService.Service
{
    public class InterviewService:IInterviewService
    {
        List<InterviewModel> interviews = new List<InterviewModel>();

        public List<InterviewModel> Interviews() => interviews;

        public InterviewModel GetInterview(Guid Id) => interviews.FirstOrDefault(x=>x.Id == Id);
       
    }
}
