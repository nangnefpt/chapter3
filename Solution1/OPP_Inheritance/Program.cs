using System.Xml.Linq;

class Employee
{
    private int id;
    private string name;

    //Constructor
    public Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    //Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}
class Manager:Employee
{
    private string email;
    public Manager(int id, string name, string email) : base(id, name)
    {
        this.Email = email;
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public override string ToString()
    {
        return $"Id:{Id}, Name: {Name}, Email: {Email}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Manager nang = new Manager(100, "Nang", "nangne123@gmail.com");
        Console.WriteLine(nang);
        Console.ReadLine();
    }
}