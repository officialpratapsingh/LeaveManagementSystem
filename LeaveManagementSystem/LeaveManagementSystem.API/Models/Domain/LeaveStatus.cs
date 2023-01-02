namespace LeaveManagementSystem.API.Models.Domain
{
    public class LeaveStatus
    {

        public Guid Id { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string submittedTo { get; set; }

        public string status  { get; set; }

        public Guid EmployeeId { get; set; }
        public Guid LeaveId { get; set; }

        // navigation properties 
        public Employee employee { get; set; }

        public Leave leave { get; set; }
    }
}
