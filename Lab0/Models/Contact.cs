using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.Models;

public class Contact
{
    [HiddenInput] public int Id { get; set; }

    [Display(Name = "Imię")]
    [Required]
    [StringLength(maximumLength: 50, MinimumLength = 2)]
    public string? Name { get; set; }

    [Display(Name = "Adres email")]
    [EmailAddress]
    [Required]
    public string? Email { get; set; }

    [Display(Name = "Data urodzin")]
    [DataType(DataType.Date)]
    public DateOnly BirthDate { get; set; }
    
    
    public Producent? Producent { get; set; }
    public int? ProducentId { get; set; }
}