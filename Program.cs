using System;
using System.IO;

class Train
{
    public string Number;
    public string Destination;
    public string DepartureTime;
    public string TravelTime;

    public void WriteToFile(StreamWriter writer)
    {
        writer.WriteLine(Number + ";" +
                         Destination + ";" +
                         DepartureTime + ";" +
                         TravelTime);
    }

    public void ReadFromFile(string line)
    {
        string[] data = line.Split(';');

        Number = data[0];
        Destination = data[1];
        DepartureTime = data[2];
        TravelTime = data[3];
    }

    public void Show()
    {
        Console.WriteLine("Номер поїзда: " + Number);
        Console.WriteLine("Станція: " + Destination);
        Console.WriteLine("Час відправлення: " + DepartureTime);
        Console.WriteLine("Час у дорозі: " + TravelTime);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        string fileName = "INFO.TXT";

        Console.Write("Введіть кількість поїздів: ");
        int n = int.Parse(Console.ReadLine());

        Train[] trains = new Train[n];

        for (int i = 0; i < n; i++)
        {
            trains[i] = new Train();

            Console.WriteLine($"\nПоїзд #{i + 1}");

            Console.Write("Номер поїзда: ");
            trains[i].Number = Console.ReadLine();

            Console.Write("Станція призначення: ");
            trains[i].Destination = Console.ReadLine();

            Console.Write("Час відправлення (год:хв): ");
            trains[i].DepartureTime = Console.ReadLine();

            Console.Write("Час у дорозі: ");
            trains[i].TravelTime = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < n; i++)
            {
                trains[i].WriteToFile(writer);
            }
        }

        Console.WriteLine("\nДані записані у файл.");

        Console.WriteLine("\nПоїзди, що відправляються не пізніше 18:00:\n");

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Train train = new Train();

                train.ReadFromFile(line);

                TimeSpan depTime = TimeSpan.Parse(train.DepartureTime);

                if (depTime <= new TimeSpan(18, 0, 0))
                {
                    train.Show();
                }
            }
        }

        Console.WriteLine("Натисніть будь-яку клавішу...");
        Console.ReadKey();
    }
}
