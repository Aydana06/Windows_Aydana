

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab1_calc
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Memory memory = new Memory();

            while (true)
            {
                Console.WriteLine("\n1. Add\n2. Subtract\n3. Save to memory\n4. Show memory\n5. Modify memory item\n6. Recall \n7. Clear \n8. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "8") break;

                double number = 0;

                if (choice == "1" || choice == "2")
                {
                    Console.Write("Enter a number: ");
                    if (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Invalid input. Press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }
                }
                switch (choice)
                {
                    case "1":
                        calculator.Add(number);
                        break;
                    case "2":
                        calculator.Subtract(number);
                        break;

                    case "3":
                        memory.Save(calculator.result);
                        Console.WriteLine("Saved to memory.");
                        break;

                    case "4":
                        var items = memory.GetAll();
                        Console.WriteLine("Memory Items:");
                        for (int i = 0; i < items.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {items[i].Value}");
                        }
                        break;

                    case "5":
                        Console.Write("Enter memory index to modify: ");
                        int index = Convert.ToInt32(Console.ReadLine());

                        MemoryItem item = memory.GetItem(index);
                        if (item != null)
                        {
                            Console.Write("Enter value to add/subtract: ");
                            double modifyValue = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Add or Subtract? (a/s): ");
                            string op = Console.ReadLine().ToLower();

                            if (op == "a")
                            {
                                item.Add(modifyValue);
                                Console.WriteLine("Value updated.");
                            }
                            else if (op == "s")
                            {
                                item.Subtract(modifyValue);
                                Console.WriteLine("Value updated.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid operation.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid memory index.");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Recalled from memory: {memory.Recall()}");
                        break;

                    case "7":
                        memory.Clear();
                        Console.WriteLine("Memory cleared.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
