using StudentExample;

Student angelo = new Student();



try
{
    angelo.FirstName = "         A                        ";

    angelo.LastName = "         Encarnacion      ";
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine(angelo.FullName);