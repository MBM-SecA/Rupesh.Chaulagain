
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
     [Key]
    public int Id{get; set;}
    [Display(Name = "First Name")]
    [Required (ErrorMessage = "First Name required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last Name required")]
    public string SurName { get; set; }
    
    public string Address{ get; set; }

    public char? Gender{get;set;}='M';
    
   
    public double? Salary{ get; set; }
    public Department Department {get;set;}
    public int DepartmentId {get;set;}
      

    
}      
   

        