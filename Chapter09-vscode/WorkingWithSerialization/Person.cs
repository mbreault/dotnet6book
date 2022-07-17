namespace Packt.Shared;
using System.Xml.Serialization;
public class Person{
    public Person() { }
    public Person(decimal initialSalary){
        Salary = initialSalary;
    }
    protected decimal Salary;
    [XmlAttribute("fname")]
    public string? FirstName { get; set; }
    [XmlAttribute("lname")]
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
}

