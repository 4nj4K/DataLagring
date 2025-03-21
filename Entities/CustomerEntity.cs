using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace Data.Entities;

public class CustomerEntity
{
    [Key]
    public int Id { get; set; }
    public string CustomerName { get; set; } = null!;

    public virtual ICollection<ProjectEntity> Projects { get; set; } = [];
}
