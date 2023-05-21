using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Library
    {
        public string Name { get; set; }
        public string NameBook { get; set; }
        public string Date { get; set; }

        public Library() { }
        public Library(string name, string book, string date)
        {
            Name = name;
            NameBook = book;
            Date = date;
        }

        virtual public void Print()
        {
            Console.WriteLine($"ФИО читателя: {Name}\nНазвание книги: {NameBook}\nДата выдачи: {Date}");
        }
    }
    class Libr : IEnumerable
    {
        private ArrayList list;
        public Libr()
        {
            list = new ArrayList();
        }
        public Libr(ArrayList a)
        {
            list = a;
        }
        public void Add(Library l)
        {
            list.Add(l);
        }
        public Libr Clone()
        {
            return new Libr(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
