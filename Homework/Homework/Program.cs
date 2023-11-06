// Cześć, nie wiem czy do końca o to chodziło, ale poproszę o konstruktywną krytykę.  

string myName = "Ewa";
string mySex = "female";
var myAge = 33;
if (myName == "Ewa" && myAge == 33 && mySex == "female")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (mySex == "male" && myAge < 18 && myAge >= 16 && myName != "Ewa")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (mySex == "female" && myAge >= 18 && myAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (mySex == "female" && myAge >= 30 && myAge < 110)
{
    Console.WriteLine("Jesteś dorosłą kobietą");
}
else if (mySex == "male" && myAge >= 18 && myAge < 110)
{
    Console.WriteLine("Jesteś dorosłym mężczyzną");
}
else if (mySex == "male" && myAge < 16 && myAge > 10)
{
    Console.WriteLine("Jesteś nastolatkiem");
}
else if (mySex == "female" && myAge < 18 && myAge > 10)
{
    Console.WriteLine("Jesteś nastolatką");
}
else if (mySex == "female" && myAge < 10)
{
    Console.WriteLine("Jesteś dzieckiem");
}
else if (mySex == "male" && myAge < 10)
{
    Console.WriteLine("Jesteś dzieckiem");
}
else if (mySex == "male" && myAge > 110)
{
    Console.WriteLine("Jest już raczej po Tobie");
}
else if (mySex == "female" && myAge > 110)
{
    Console.WriteLine("Jest już raczej po Tobie");
}