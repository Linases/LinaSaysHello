using AqaLabHomeworkFilesStorage.Task7;
using ElectronicsStore;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------Printer--------------");
        ElectricalDevice printer = new Printer("printer", 27, 36, 45);
        Console.WriteLine(printer.Description);
        printer.TurnOn();
        printer.Print();
        printer.TunrnOff();

        Polaroid polaroid = new Polaroid(23, 23, 2.5, "sony", 265);
        Console.WriteLine(polaroid.Description);
        MobilePhone mp = new MobilePhone(4.5, "Apple", 300);
        mp.TakePhoto();
        Console.WriteLine(mp.Description);
        polaroid.Print();
        polaroid.TurnOn();
        mp.TurnOn();
        mp.TunrnOff();
    }
}