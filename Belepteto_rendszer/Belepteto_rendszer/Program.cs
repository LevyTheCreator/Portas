Console.WriteLine(Directory.GetCurrentDirectory());

Console.Write("Személy vagy Jármű: ");
string personOrVehicle = Console.ReadLine();

while (personOrVehicle.ToLower() != "személy" && personOrVehicle.ToLower() != "jármű")
{
    Console.WriteLine("Helytelen adat!");
    personOrVehicle = Console.ReadLine();
}

if (personOrVehicle.ToLower() == "személy")
{
    Console.Write("Adja meg a személy nevét: ");
    string name = Console.ReadLine();

    Console.Write("Adja meg a személy igazolványszámát: ");
    int idNumber = int.Parse(Console.ReadLine());

    DateTime dateTime = DateTime.Now;

    File.AppendAllText("person.txt", $"{name};{idNumber};{dateTime}\n");
    Console.WriteLine("Person succesfully added to file");
}
else
{
    Console.Write("Adja meg a jármű rendszámát: ");
    string licensePlate = Console.ReadLine();

    Console.Write("Adja meg a jármű típúsát: ");
    string type = Console.ReadLine();

    DateTime dateTime2 = DateTime.Now;

    File.AppendAllText("vehicle.txt", $"{licensePlate};{type};{dateTime2}\n");
    Console.WriteLine("Vehicle succesfully added to file");
}