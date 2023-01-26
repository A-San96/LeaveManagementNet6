namespace LeaveManagement.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; } // Nombre de jour de congé Par défaut qu'un employée peut prendre
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
