// zadanie
string name = "Jarek";
int age = 40;
string gen = "male";

if (name == "Jarek" && age < 18)
{
    Console.WriteLine("Jarek jest niepelnoletni!");
}
else if (age < 18 && gen != "male")
{
    Console.WriteLine("Pełnoletnia kobieta");
}
else if (name == "Jarek" && age == 40)
{
    Console.WriteLine("Jarek, lat 40");
}