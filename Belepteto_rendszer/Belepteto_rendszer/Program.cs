Console.Write("Személy vagy Jármű: ");
string p_or_v = Console.ReadLine();

while (p_or_v.ToLower() != "személy" || p_or_v.ToLower() != "jármű")
    if (p_or_v.ToLower() == "személy")
    {

    }
    else if (p_or_v.ToLower() == "jármű")
    {

    }
    else
    {
        Console.WriteLine("Helytelen adat!");
    }