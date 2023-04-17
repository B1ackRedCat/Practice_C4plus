using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Book
    {
        private string _number;
        private string _title;
        private string _author;
        private DateOnly _publishYear;
        private string _genre;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; } 
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public DateOnly PublishYear
        {
            get { return _publishYear; }
            set { _publishYear = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public override string ToString()
        {
            return $"Book number: {_number}\n" +
                $"Book title: {_title}\n"+
                $"Author: {_author}\n" +
                $"Year of publishing: {_publishYear}\n" +
                $"Genre: {_genre}\n";
        }
    }
}
