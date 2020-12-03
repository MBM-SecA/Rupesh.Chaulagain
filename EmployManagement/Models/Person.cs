
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
      

    public static List<Person> GetPerson()
    {
        Person empl1 = new Person() { FirstName = "Rupesh", SurName = "Chaulagain",  Address = "Kapan",  Gender = 'M',  Salary = 00.0,};
        Person empl2 = new Person() { FirstName = "Rupesh", SurName = "Chaulagain", Address = "Kapan", Gender = 'M', Salary = 89.0 };
        Person empl3 = new Person() { FirstName = "Sako", SurName = "Oz", Address = "Los Angeles", Gender = 'M', Salary = 47.0 };
        Person empl4 = new Person() { FirstName = "Johnny", SurName = "minds", Address = "Los Angeles", Gender = 'M', Salary = 68.0 };
        Person empl5 = new Person() { FirstName = "Wazza", SurName = "Minds", Address = "California", Gender = 'M', Salary = 26.0 };
        Person empl6 = new Person() { FirstName = "Danny", SurName = "Carry", Address = "Los Angeles", Gender = 'M', Salary = 86.0 };
        Person empl7 = new Person() { FirstName = "Liza", SurName = "oldman", Address = "Santa,Monica", Gender = 'F', Salary = 45.0 };
        Person empl8 = new Person() { FirstName = "Rupesh", SurName = "Chaulagain", Address = "Kapan", Gender = 'M', Salary = 00.0 };
        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6, empl7, empl8 };
        return employees;

    }  
}      
   

        