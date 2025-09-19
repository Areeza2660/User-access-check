using System;

class AccessCheck
{
    static void Main()
    {
        Console.WriteLine(">>> Tjek af brugeradgang <<<");


        Console.Write("Skriv brugernavn: ");
        string user = Console.ReadLine() ?? "";

        Console.Write("Skriv kodeord: ");
        string pass = Console.ReadLine() ?? "";

        Console.Write("Skriv bruger-ID: ");
        uint id;
        if (!uint.TryParse(Console.ReadLine(), out id))
        {
            id = 0; 
        }


        bool admin = id > 65536;


        bool userOk = user.Length >= 3;


        bool hasChar = pass.Contains("@") || pass.Contains("|") || pass.Contains("$");


        bool passOk = hasChar &&
                      ((admin && pass.Length >= 20) ||
                       (!admin && pass.Length >= 16));


        Console.WriteLine();
        Console.WriteLine("Administratorstatus: " + admin);
        Console.WriteLine("Gyldigt brugernavn: " + userOk);
        Console.WriteLine("Gyldigt kodeord: " + passOk);
    }
}