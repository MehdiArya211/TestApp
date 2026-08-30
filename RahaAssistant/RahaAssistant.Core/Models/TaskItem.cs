namespace RahaAssistant.Core.Models;

public class TaskItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime Date { get; set; }
    public bool IsCompleted { get; set; }
    public int Priority { get; set; }
}
