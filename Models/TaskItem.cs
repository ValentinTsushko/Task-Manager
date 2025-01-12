namespace Task_Manager.Models
{
    public class TaskItem
    {
        public string Titel { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public DateOnly DateOfEnd { get; set; }
    }
}
