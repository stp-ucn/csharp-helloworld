using HelpCode.Data;
using HelpCode.Model;

Console.WriteLine("Hello, World!");

StudentAccess studAcc = new StudentAccess();

List<Student> studs = studAcc.DemoStudents;

Console.WriteLine("Students in this world:");
foreach (Student student in studs)
{
    Console.WriteLine(student);
}
Console.WriteLine("Say what you think about this");
string s = Console.ReadLine();

Console.WriteLine("Thank you for saying " + s);