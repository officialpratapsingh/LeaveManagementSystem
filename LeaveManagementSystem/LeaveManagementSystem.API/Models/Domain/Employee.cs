namespace LeaveManagementSystem.API.Models.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string empName { get; set; }
       
        public int empAge { get; set; }
        public string empNumber  { get; set; }
        public string empEmail{ get; set; }
        // navigation properties 
        // one employee can have multiple leaves 
        public IEnumerable<LeaveStatus> leavestatus { get; set; }


    }
}
