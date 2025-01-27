using AssignmentService.Models;
using System.Collections.Generic;
using static AssignmentService.Models.AssignmentModel;

namespace AssignmentService.Service
{
    public class AssignmentService : IAssignmentService
    {
        List<AssignmentModel> assignments = new List<AssignmentModel>()
        {
            new AssignmentModel() { Id = Guid.NewGuid(), NameTask = "Тестовое задание1", DescriptionTask = "Описание тестового задания", Stak = [ Stack.TypeScript, Stack.React], ExecutionTime = 4 }
        };
        public AssignmentModel GetAssignment(Guid Id)
        {
            return assignments.FirstOrDefault(a => a.Id == Id);
        }
        public List<AssignmentModel> GetAll() { return assignments; }
        public string AddAssignment(AssignmentModel assignment)
        {
            string result = string.Empty;
            try
            {
                 assignments.Add(assignment);
            }
            catch (Exception ex) 
            {
                result = ex.Message;
            }
            return result == string.Empty ? $"Добавлено задание {assignment.NameTask}" : $"Ошибка - {result}";
        }
        public string RemoveAssignment(Guid Id)
        {
            string result = string.Empty;
            try
            {
                assignments.Remove(GetAssignment(Id));
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result == string.Empty ? $"Удалено задание номер: {Id.ToString()}" : $"Ошибка - {result}";
        }
        public AssignmentModel UpdateAssignment(AssignmentModel assignment)
        {
            AssignmentModel assignmentModel = assignments.FirstOrDefault(x=>x.Id == assignment.Id);

            assignmentModel.Id = assignment.Id;
            assignmentModel.NameTask = assignment.NameTask;
            assignmentModel.DescriptionTask = assignment.DescriptionTask;
            assignmentModel.Stak = assignment.Stak;
            assignmentModel.ExecutionTime = assignment.ExecutionTime;

            return assignmentModel;
        }
    }
}
