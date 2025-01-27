using CandidateService.Models;

namespace CandidateService.Service
{
    public class CandidateService : ICandidateService
    {

        public List<CandidateModels> testDataCandidates = new List<CandidateModels>() {
            new CandidateModels { Id = new Guid("fcb15e32-bf92-4578-ba81-60462ff60447"), FullName = "Петров Пётр Петрович", Email = "petrov.pp@gmail.com", BirthDate = new DateTime(2001, 01, 01), PhoneNumber = "+123-32-432" },
            new CandidateModels { Id = Guid.Parse("f4318941-26c8-4ea9-93c3-0180eaf9ff46"), FullName = "Сидоров Сидор Петрович", Email = "sidorov.sp@gmail.com", BirthDate = new DateTime(2001, 03, 01), PhoneNumber = "+323-32-432" },
            new CandidateModels { Id = Guid.Parse("3c858a99-a2d3-457a-8635-dc3b9b412531"), FullName = "Иванов Иван Иванович", Email = "ivanid.ii@gmail.com", BirthDate = new DateTime(2001, 05, 01), PhoneNumber = "+223-32-432" },
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


