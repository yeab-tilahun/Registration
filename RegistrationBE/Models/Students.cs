using Microsoft.AspNetCore.Mvc;

namespace RegistrationBE.Models;
public class Student
{
    public Guid? StudentId { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public int? Phone { get; set; }
    public string? Address { get; set; }
    public string? Debr { get; set; }
    public bool? HaveRepentFather { get; set; } = false;
    public string? PrefferedLocation { get; set; }
    public bool? OwnCar { get; set; } = false;
    public string? CarInfo { get; set; }
    public bool? NeedCar { get; set; } = false;
    public string? ChurchExperiance { get; set; }
    public bool? LearnedBefore { get; set; } = false;

}