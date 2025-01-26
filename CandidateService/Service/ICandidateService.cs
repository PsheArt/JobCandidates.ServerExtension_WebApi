using CandidateService.Models;
namespace CandidateService.Service
{
    public interface ICandidateService
    {
        CandidateModels GetCandidate(Guid Id);
        List<CandidateModels> GetCandidates();
        string AddCandidate(CandidateModels candidate);
        string RemoveCandidate(Guid Id);
        CandidateModels UpdateCandidate(CandidateModels model);


    }
}
