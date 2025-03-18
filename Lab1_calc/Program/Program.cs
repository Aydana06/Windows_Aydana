using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LibraryCalc.Mem;
using LibraryCalc.Calculator;

namespace Lab1_calc.Program
{
    internal class Program
    {
        static void Main()
        {
            //  Тооны машин болон санах ойн объектийг үүсгэж байна.
            Calculator calculator = new();
            Memory memory = new();

            while (true)
            {
                Console.WriteLine("\n1. Add\n2. Subtract\n3. Save to memory\n4. Show memory\n5. Modify memory item \n6. Reset \n7. Clear \n8. Exit");
                Console.Write("Enter choice: ");

                // Хэрэглэгчийн оролтыг авах

                string? choice = Console.ReadLine();

                // Хэрэв хэрэглэгч "8"-г сонговол програмыг дуусгах
                if (choice == "8") break;

                double number = 0;

                // Сонголт 1 эсвэл 2 бол тоо оруулах шаардлагатай
                if (choice == "1" || choice == "2")
                {
                    Console.Write("Enter a number: ");
                    if (!double.TryParse(Console.ReadLine(), out number)) // Оролт зөв эсэхийг шалгах
                    {
                        Console.WriteLine("Invalid input. Press any key to continue...");
                        Console.ReadKey();
                        continue;// Хэрэв оруулсан утга буруу бол үргэлжлүүлэх
                    }
                }
                // Сонголт болон үйлдлийг гүйцэтгэх
                switch (choice)
                {
                    case "1": // Нэмэх
                        calculator.Add(number);
                        Console.WriteLine($"result: {calculator.Result}");
                        break;
                    case "2":  // Хасах
                        calculator.Subtract(number);
                        Console.WriteLine($"result: {calculator.Result}");
                        break;

                    case "3": // Санах ойнд хадгалах
                        memory.Save(calculator.Result);
                        break;

                    case "4": // Санах ойг харуулах
                        var items = memory.PrintMemoryItems();
                        Console.WriteLine("Memory Items:");
                        for (int i = 0; i < items.Count; i++) //Санах ойн бүх элементүүдийг харуулах
                        {
                            Console.WriteLine($"[{i}] {items[i].Value}");
                        }
                        break;

                    case "5":  // Санасан тоон дээр үйлдэл хийх
                        Console.Write("Enter the memory index: ");
                        string? indexInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(indexInput) || !int.TryParse(indexInput, out int index))
                        {
                            Console.WriteLine("Invalid memory index.");
                            break;
                        }

                        // Индексээр санах ойн элементийг авах
                        MemoryItem? item = memory.GetItem(index);
                        if (item != null)
                        {
                            Console.Write("Add or Subtract (+/-): ");
                            string? op = Console.ReadLine();

                            switch (op)
                            {
                                case "+":
                                    item.Add(calculator.Result);
                                    Console.WriteLine($"memoryItemResult: {item.Value}");
                                    break;
                                case "-":
                                    item.Subtract(calculator.Result);
                                    Console.WriteLine($"memoryItemResult: {item.Value}");
                                    break;
                                default:
                                    Console.WriteLine("Invalid operation");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid memory index.");
                        }
                        break;
                    case "6": // Санах ойг цэвэрлэх
                        calculator.Reset();
                        break;
                    case "7":
                        memory.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
