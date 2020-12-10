using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int Id {get; set;}
    [Required (ErrorMessage = "Department Name required")]
    public string Name {get; set;}

    [Required (ErrorMessage = "Department Code required")]
    public string Code {get; set;}
    public string Description {get; set;}
    public DateTime StartDate{get; set;}

    public List<Person>People {get;set;}

}