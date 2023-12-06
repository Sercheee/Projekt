var sex = "kobieta";
var name = "Ewa";
var age = 29;
var age1 = 17;
if (sex == "kobieta") 
{
    if (name == "Ewa" && age < 30 )
    {
        Console.WriteLine("Ewa");
        Console.WriteLine("kobieta poniżej 30 lat");
    }
    if (age1 < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
else
    {
    if (name == "Ewa")
        Console.WriteLine("To jest inna Kobieta");
    }
