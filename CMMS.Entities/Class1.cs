namespace CMMS.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = "Operator";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<WorkOrder> ReportedWorkOrders { get; set; } = new List<WorkOrder>();
        public ICollection<WorkOrder> AssignedWorkOrders { get; set; } = new List<WorkOrder>();
    }
}