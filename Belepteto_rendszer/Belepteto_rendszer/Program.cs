Console.Write("Személy vagy Jármű: ");
string personOrVehicle = Console.ReadLine();

while (personOrVehicle.ToLower() != "személy" && personOrVehicle.ToLower() != "jármű")
{
    Console.WriteLine("Helytelen adat!");
    personOrVehicle = Console.ReadLine();
}

if (personOrVehicle.ToLower() == "személy")
{
    
}
else
{

}