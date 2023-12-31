﻿namespace Todo_App.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.Red;

    public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
}
