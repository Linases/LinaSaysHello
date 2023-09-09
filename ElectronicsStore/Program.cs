using AqaLabHomeworkFilesStorage.Task7;
using ElectronicsStore;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------Printer--------------");
        Printer printer = new Printer("printer", 27, 36, 45);
        Console.WriteLine(printer.Description);
        printer.TurnOn();
        printer.Print();
        printer.TunrnOff();

        Console.WriteLine("------------------Polaroid--------------");

        Polaroid polaroid = new Polaroid(23, 23, 2.5, "sony", 265);
        Console.WriteLine(polaroid.Description);
        polaroid.Print();
        polaroid.TurnOn();
        polaroid.TakePhoto();
        polaroid.TunrnOff();

        Console.WriteLine("------------------MobilePhone--------------");
        MobilePhone mp = new MobilePhone(4.5, "Apple", 300);
        mp.TakePhoto();
        Console.WriteLine(mp.Description);
        mp.TurnOn();
        mp.TunrnOff();
    }
}