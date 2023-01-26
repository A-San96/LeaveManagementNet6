namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; } // Nombre de jour de congé Par défaut qu'un employée peut prendre
      
    }
}
