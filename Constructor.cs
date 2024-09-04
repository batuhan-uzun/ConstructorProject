using ConstructorProject;
using System.Threading.Channels;

Baby baby1 = new Baby(); // We create a baby1 object using the default Constructor
baby1.Name = "Ahmet";
baby1.Surname = "Yılmaz";
Console.WriteLine($"{baby1.Name} {baby1.Surname} {baby1.BirthDate.ToString("dd.MM.yyyy HH:mm")}");


Console.WriteLine("Lütfen bebeğin adını giriniz:");
string name = Console.ReadLine();
Console.WriteLine("Lütfen bebeğin soyadını giriniz:");
string surname = Console.ReadLine();

Baby baby2 = new Baby(name,surname); // We fill in the parameters of our alternative Constructor by taking name and surname information
Console.WriteLine($"{baby2.Name} {baby2.Surname} {baby2.BirthDate.ToString("dd.MM.yyyy HH:mm")}");
