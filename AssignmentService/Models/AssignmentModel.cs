using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentService.Models
{
    public class AssignmentModel
    {
        public Guid Id { get; set; }
        public string NameTask { get; set; }
        public string DescriptionTask { get; set; }
        
        public Stack[] Stak { get; set; }
        public int ExecutionTime {get;set; }

        public enum Stack
        {
            None = 0,
            JavaScript = 1,
            TypeScript = 2,
            React = 3,
            NodeJS = 4,
            Golang = 5,
            Python = 6,
            Java = 7,
            CSharp = 8,
            PHP = 9
        }


        
    }
}
