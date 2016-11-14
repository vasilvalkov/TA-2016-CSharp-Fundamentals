using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhone = Console.ReadLine();
        string companyFax = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerName = Console.ReadLine();
        string managerFamily = Console.ReadLine();
        byte managerAge = byte.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhone);
        Console.WriteLine("Fax: {0}", companyFax == "" ? "(no fax)" : companyFax);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerName, managerFamily, managerAge, managerPhone);
    }
}
