using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManagerPrueba.Models;

public partial class Task
{
    public int Id { get; set; }

    [StringLength(100, ErrorMessage = "El título no debe exceder los 100 caracteres.")]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly? DueDate { get; set; }

    [Range(1, 5, ErrorMessage = "La prioridad deben ser entre 1 y 5")]
    public int Priority { get; set; }

    public bool IsCompleted { get; set; } = false;

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
