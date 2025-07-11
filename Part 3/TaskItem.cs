using System;

public class TaskItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? ReminderDate { get; set; }
    public bool IsCompleted { get; set; }

    public string DisplayText => $"{Title} {(ReminderDate != null ? $"- {ReminderDate:t}" : "")}";
}
