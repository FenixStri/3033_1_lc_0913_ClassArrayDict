// Fenix Strickland
// MIS 3033 001 class


Person p1;
p1 = new Person();
Console.WriteLine(p1.Name);
//p1.Name = "David";

Student stu;
stu = new Student();

Console.WriteLine(p1.);

Console.ReadLine();

public class Person
{

    private string name = "Fenix Strickland";

    public int age { get; set; } = 20;

    public double weight { get; set; } = 120;

    //public string Name { get; set; }
    public string Name { get 
        {
            return name.Substring(0,2)+"***";
        }
    
    }

}

public class Student:Person
{
    public string stuID { get; set; } = "defaultOUID";

   public void PrintInfor()
    {
        Console.WriteLine(this.weight);
        Console.WriteLine(this.Name);
    }
}
