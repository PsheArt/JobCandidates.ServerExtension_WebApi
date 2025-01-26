using CandidateService.Models;

namespace CandidateService.Service
{
    public class CandidateService : ICandidateService
    {

        public List<CandidateModels> testDataCandidates = new List<CandidateModels>() {
            new CandidateModels { Id = new Guid(), FullName = "Петров Пётр Петрович", Email = "petrov.pp@gmail.com", BirthDate = new DateTime(2001, 01, 01), PhoneNumber = "+123-32-432" },
            new CandidateModels { Id = new Guid(), FullName = "Сидоров Сидор Петрович", Email = "sidorov.sp@gmail.com", BirthDate = new DateTime(2001, 03, 01), PhoneNumber = "+323-32-432" },
            new CandidateModels { Id = new Guid(), FullName = "Иванов Иван Иванович", Email = "ivanid.ii@gmail.com", BirthDate = new DateTime(2001, 05, 01), PhoneNumber = "+223-32-432" },
        };
        
        public CandidateService() 
        {
        }

        public CandidateModels GetCandidate(Guid Id)
        {
          return testDataCandidates.FirstOrDefault(x => x.Id == Id);
        }
        public List<CandidateModels> GetCandidates() 
        {
            return testDataCandidates;
        }
        public string AddCandidate(CandidateModels candidate) 
        {
            testDataCandidates.Add(candidate);
            return $"Успешно добавлен кандидат - {candidate.FullName}";
        }
        public string RemoveCandidate(Guid Id)
        {
            testDataCandidates.Remove(GetCandidate(Id));
            return "Кандидат удалён";
        }
        public CandidateModels UpdateCandidate(CandidateModels candidate) 
        {
            CandidateModels curCandidate = GetCandidate(candidate.Id);
            curCandidate.FullName = candidate.FullName;
            curCandidate.Email = candidate.Email;
            curCandidate.PhoneNumber = candidate.PhoneNumber;
            curCandidate.BirthDate = candidate.BirthDate;
            return curCandidate;
        }
      
    }
}


