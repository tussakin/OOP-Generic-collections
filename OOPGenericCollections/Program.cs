namespace OOPGenericCollections;

class Program
{
    static void Main()
    {
        
        // Här skapar vi 5 objekt av Employee klassen med olika värden 
        var employee1 = new Employee(name: "Sarah", id: 4, gender: "Female", salary: 40000);
        var employee2 = new Employee(name: "Morgan", id: 8, gender: "Male", salary: 35500);
        var employee3 = new Employee(name: "Larry", id: 18, gender: "Male", salary: 25900);
        var employee4 = new Employee(name: "Nicole", id: 1, gender: "Female", salary: 38000);
        var employee5 = new Employee(name: "Sam", id: 13, gender: "Non binary", salary: 42400);
    
        
        
        // Skapar en stack och lägger sedan till alla 5 objekt med push
        var employeeStack = new Stack<Employee>();
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3);
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);
    
        /*En foreach loop för att loopa igenom alla objekt i stacken, och en count för
         visa antalet objekt i stacken*/
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("All Employees \n");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine(employee);
            Console.WriteLine(employeeStack.Count);
        }
    
        // Print statements
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Retrieve Using Pop method \n");
    
        /* En while loop som körs fram till att vi inte har mer objekt kvar i stacken 
         I loopen så använder vi pop, den returnerar det översta objektet i stacken 
         för att sedan ta bort den från stacken. Så här skriver vi ut det översta
         objektet, tar bort det och sen börjar loopen om och skriver ut det nya 
         översta objektet. */
        while (employeeStack.Count > 0)
        {
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine(employeeStack.Count);
        }
        
        // Här använder vi push för att lägga til alla objekt i stacken igen
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3);
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);
    
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Retrieve Using Peek method \n"); 
        
        /* Här använder vi peek för att tjuvkika på det översta objektet i stacken
         men vi behåller den fortfarande i stacken. Så som här när vi gör peek 2 gånger, 
         så kikar vi på samma objekt 2 gånger eftersom vi inte tar bort något från stacken
         och peek endast kollar på det översta. Detta bevisas tydligare iom att vi 
         räknar hur många objekt vi har i stacken efter varje peek. */
        Console.WriteLine(employeeStack.Peek());
        Console.WriteLine(employeeStack.Count);
        Console.WriteLine(employeeStack.Peek());
        Console.WriteLine(employeeStack.Count);
    
        
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Retrieve Using Contains \n"); 
        
        // Här kollar vi om vi har "employee3" i listan och skriver ut efter resultatet
        Console.WriteLine(employeeStack.Contains(employee3) ? "Employee 3 exists" 
            : "Employee 3 does not exist");
    
        /* Här skapas en ny lysta som kallas employeeList, som är en lista som
         består av Employee objekt. Vi lägger till våra objekt från tidigare */
        var employeeList = new List<Employee>()
        {
            employee1,
            employee2,
            employee3,
            employee4,
            employee5
        };
        
        // Här kontrolleras det om employee2 existerar i listan med passande utskrift. 
        Console.WriteLine(employeeList.Contains(employee2)
            ? "Employee 2 exists in the list"
            : "Employee does not exist in the list");
        
        
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Retrieve Using Find \n"); 
        /* Här söker vi efter ett specifikt värde i objekten
         av employee. Vi går igenom listan a employees och skriver ut den första employee som 
         matchar gender == Male */
        var maleEmployee = employeeList.Find(employee => employee.Gender == "Male");
        Console.WriteLine(maleEmployee); 
        
        
        /* FindAll(), letar fram alla objekt som matchar det som jämförs, här är det egenskapen
         gender som ska var == Male. Den lägger till alla objekt som matchar i en lista. Eftersom det
         är en lista så använder jag en foreach för att skriva ut hela listan i konsolen. */
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Retrieve Using FindAll \n"); 
        var allMaleEmployee= employeeList.FindAll(employee => employee.Gender == "Male");
        
        foreach (var allMaleEmplyees in allMaleEmployee)
        {
            Console.WriteLine(allMaleEmplyees);
        } 
        
    }
}