/// Zadanie dzień 4
string personName = "Ewa";
string gender = "woman";
uint personAge = 33;
Console.WriteLine("name - " + personName);
Console.WriteLine("gender - " + gender);
Console.WriteLine("person age - " + personAge);
if (gender == "woman" && personAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta nie znaleziona");
}
if (gender == "woman" && personName == "Ewa" && personAge == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else
{
    Console.WriteLine("Ewa nie znaleziona");
}
if (gender == "man" && personAge < 18)
{
    Console.WriteLine("Niepełnoletny mążczyzna");
}
else
{
    Console.WriteLine("Mężczyzna nie znaleziony");
}