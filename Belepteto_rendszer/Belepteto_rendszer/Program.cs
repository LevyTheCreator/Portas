string filePathPerson = "../../../../../../Portas/stored_data/person.txt";
string filePathVehicle = "../../../../../../Portas/stored_data/vehicle.txt";

Console.Write("Lekérés vagy hozzáadás: ");
string retriveOrAdd = Console.ReadLine();

while (retriveOrAdd.ToLower() != "lekérés" && retriveOrAdd.ToLower() != "hozzáadás")
{
    Console.WriteLine("Helytelen bemenet!");
    retriveOrAdd = Console.ReadLine();
}

if (retriveOrAdd.ToLower() == "hozzáadás")
{
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

        File.AppendAllText(filePathPerson, $"{name};{idNumber};{dateTime}\n");
        Console.WriteLine("Person succesfully added to file");
    }
    else
    {
        Console.Write("Adja meg a jármű rendszámát: ");
        string licensePlate = Console.ReadLine();

        Console.Write("Adja meg a jármű márkáját: ");
        string brand = Console.ReadLine();

        DateTime dateTime = DateTime.Now;

        File.AppendAllText(filePathVehicle, $"{licensePlate};{brand};{dateTime}\n");
        Console.WriteLine("Vehicle succesfully added to file");
    }

}
else
{
    Console.Write("Személy vagy jármű: ");
    string retrivePOrV = Console.ReadLine();

    while (retrivePOrV.ToLower() != "személy" && retrivePOrV.ToLower() != "jármű")
    {
        Console.WriteLine("Helytelen Adat!");
        retrivePOrV = Console.ReadLine();
    }

    if (retrivePOrV == "személy")
    {
        Console.Write("Adja meg a kereset személy nevét: ");
        string retriveName = Console.ReadLine();

        string[] sorok = File.ReadAllLines(filePathPerson);
        bool found = false;

        for (int i = 0; i < sorok.Length; i++)
        {
            string[] data = sorok[i].Split(";");

            if (data.Contains(retriveName))
            {
                Console.WriteLine($"Adatok: {sorok[i]}");
                found = true;
            }
            else
            {
                continue;
            }
        }

        if (found == false)
        {
                Console.WriteLine("Nincs ilyen személy!");
        }
    }
    else
    {
        Console.Write("Adja meg a kereset jármű rendszámát: ");
        string retriveLicensePlate = Console.ReadLine();

        Console.Write("Adja meg a kereset jármű márkáját: ");
        string retrivebrand = Console.ReadLine();

        string[] sorok = File.ReadAllLines(filePathVehicle);
        bool found = false;

        for (int i = 0; i < sorok.Length; i++)
        {
            string[] data = sorok[i].Split(";");

            if (data.Contains(retriveLicensePlate) && data.Contains(retrivebrand))
            {
                Console.WriteLine($"Adatok: {sorok[i]}");
                found = true;
            }
            else
            {
                continue;
            }
        }

        if (found == false)
        {
                Console.WriteLine("Nincs ilyen jármű!");
        }
    }

}