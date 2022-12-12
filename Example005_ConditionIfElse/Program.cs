Console.Write("Введите имя пользовотеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "alex")
{
    Console.WriteLine("Horray, it's Alex!");
}   
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
} 