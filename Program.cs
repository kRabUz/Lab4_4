using Lab4_4.Classes;
using System;

namespace Lab4_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AmdProcessor processor1 = new AmdProcessor(3200, 6, "AP123", 200.00M);
            AmdProcessor processor2 = new AmdProcessor(3600, 8, "AP456", 250.00M);
            IntelProcessor processor3 = new IntelProcessor(4000, 12, "AP789", 350.00M);
            IntelProcessor processor4 = new IntelProcessor(3300, 8, "AP101", 270.00M);

            AsusVideoCard videoCard1 = new AsusVideoCard("GTX 1660", "VC123", 300.00M);
            AsusVideoCard videoCard2 = new AsusVideoCard("RTX 3070", "VC456", 600.00M);
            NvidiaVideoCard videoCard3 = new NvidiaVideoCard("RX 6800", "VC789", 550.00M);
            NvidiaVideoCard videoCard4 = new NvidiaVideoCard("GTX 1650", "VC101", 200.00M);

            SystemUnit systemUnit1 = new SystemUnit("Custom PC", "SU123", 1500.00M);
            SystemUnit systemUnit2 = new SystemUnit("Gaming PC", "SU456", 2000.00M);

            systemUnit1.Add(processor1);
            systemUnit1.Add(processor3);
            systemUnit1.Add(videoCard2);
            systemUnit1.Add(videoCard4);

            systemUnit2.Add(processor2);
            systemUnit2.Add(processor4);
            systemUnit2.Add(videoCard1);
            systemUnit2.Add(videoCard3);

            Monitor monitor1 = new Monitor("Dell U2719D", 27.0, "M123", 350.00M);
            Monitor monitor2 = new Monitor("ASUS VG279Q", 27.0, "M456", 300.00M);

            Computer computer1 = new Computer();
            Computer computer2 = new Computer();

            computer1.Add(systemUnit1);
            computer2.Add(systemUnit2);
            computer1.Add(monitor2);
            computer2.Add(monitor1);

            Console.WriteLine($"Ціна на перший комп'ютер: {computer1.GetPrice()} $");
            Console.WriteLine($"Ціна на другий комп'ютер: {computer2.GetPrice()} $");
            Console.ReadKey();
        }
    }
}
