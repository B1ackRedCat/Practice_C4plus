using System.Collections;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libr LibrList = new Libr();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("1 - добавление   2 - удаление   3 - вывод всего списка   4 - вывести список читателей   5 - выход");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 5) { flag = false; }

                    if (choice == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Введите ФИО читателя: ");
                        string fio = Console.ReadLine();
                        Console.Write("Введите название книги: ");
                        string book = Console.ReadLine();
                        Console.Write("Введите дату выдачи: ");
                        string date = Console.ReadLine();
                        dic[dic.Count] = fio;
                        LibrList.Add(new Library(fio, book, date));
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Введите номер элемента, который хотите удалить: ");
                        int el = Convert.ToInt32(Console.ReadLine());
                        LibrList.RemoveAt(el - 1);
                        Console.WriteLine("Запись удалена.");
                    }
                    if (choice == 3)
                    {
                        Console.WriteLine();
                        foreach (Library lib in LibrList)
                        {
                            lib.Print();
                            Console.WriteLine("--------------------");
                        }
                    }
                    if (choice == 4)
                    {
                        Console.WriteLine();
                        foreach (KeyValuePair<int, string> keyValue in dic)
                        {
                            Console.WriteLine(keyValue.Key + 1 + "|" + keyValue.Value);
                        }
                    }
                }
                catch (FormatException) { Console.WriteLine("Необходимо ввести числовое значение!"); }
                catch (ArgumentOutOfRangeException) { Console.WriteLine("Записи под таким номером нет!"); }
                catch (Exception) { Console.WriteLine("Введены неверные данные!"); }
            }
        }
    }
}