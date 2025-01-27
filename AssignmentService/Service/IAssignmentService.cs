using AssignmentService.Models;
using Microsoft.AspNetCore.SignalR;

namespace AssignmentService.Service
{
    public interface IAssignmentService
    {
        AssignmentModel GetAssignment(Guid Id);
        List<AssignmentModel> GetAll();
        string AddAssignment(AssignmentModel assignment);
        string RemoveAssignment(Guid Id);
        AssignmentModel UpdateAssignment(AssignmentModel assignment);

    }
}
