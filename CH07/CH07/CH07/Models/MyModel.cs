using System.ComponentModel.DataAnnotations;

namespace CH07.Models;

public class MyModel
{
    [Required]
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }

}
