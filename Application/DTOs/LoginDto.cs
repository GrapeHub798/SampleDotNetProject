namespace DotNetSample.Application.DTOs;

using System.ComponentModel.DataAnnotations;

public class LoginDto {
    [Required]
    public string? EmailAddress {get; set;}
    [Required]
    public string? Password {get; set;}
}