using System;
class Customer
{
    private int Id;
    public int CustomerId
    {
        get
        {
            return Id;
        }
        set

        { Id = value; }
    }
    public string CustomwerName { get; set; } = "New customer";
    public void Print()
    {
        Console.Write($"Id: {CustomerId}, Name:{CustomwerName}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer obj = new Customer();
        obj.CustomerId = 1000;
        Console.WriteLine($"ID:{obj.CustomerId}, Name:{obj.CustomwerName}");
        obj.CustomerId = 200;
        obj.CustomwerName = "Nang";
        obj.Print();
        Console.ReadLine();
    }
}