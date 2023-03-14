
using ConsoleApp16.Services;
using ConsoleApp16.Services;

Console.WriteLine();
StudentService studentService = new StudentService();


Console.WriteLine("Quit- Enter 0: ");
Console.WriteLine("Create- Enter 1: ");
Console.WriteLine("Show- Enter 2: ");
Console.WriteLine("Id- Enter 3: ");

Console.WriteLine("\n Make a choice :");
int request = int.Parse(Console.ReadLine());

while (request != 0)
{
    switch (request)
    {
        case 1:
            studentService.Create();
            break;
        case 2:
            studentService.Show();
            break;
        case 3:
            studentService.GetById();
            break;

        default:
            Console.WriteLine("U can enter only 1,2 or 3");
            break;
    }

    Console.WriteLine("For Quit- Enter 0: ");
    Console.WriteLine("For Create Enter 1: ");
    Console.WriteLine("For Show- Enter 2: ");
    Console.WriteLine("For Id- Enter 3: ");
    request = int.Parse(Console.ReadLine());
}
