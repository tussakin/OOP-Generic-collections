namespace OOPGenericCollections;

// En klass som heter Employee med 4 olika egenskaper, samt en konstruktor. 
public class Employee
{
    public string? Name { get; set; }
    public int Id { get; set; }
    public string? Gender { get; set; }
    public int Salary { get; set; }
    
    public Employee(string name, int id, string gender, int salary)
    {
        Name = name;
        Id = id;
        Gender = gender;
        Salary = salary;
    }
    
    
    //  En override av en existerande metod ToString för att definera exakt vad som ska returneras
    // och hur det ska formateras
    public override string ToString()
    {
        return $"Name: {Name}, Id: {Id}, Gender: {Gender}, Salary: {Salary}kr";
    }
}