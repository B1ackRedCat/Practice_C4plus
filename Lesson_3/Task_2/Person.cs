using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2
{
    class Person
    {
        #region Private fields
        private String _name;
        private int _age;
        #endregion

        #region Public fields
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        #endregion

        #region Constructors
        public Person(String Name, int Age)
        {
            _name = Name;
            _age = Age;
            //DataInput();
        }
        #endregion

        #region Methods
        public void DataInput()
        {
            Console.Write("Enter a name: ");
            _name = Console.ReadLine();
            Console.Write("Enter age: ");
            _age = int.Parse(Console.ReadLine());
        }
        public override String ToString()
        {
            return $"Name: {Name}; Age: {Age}";
        }
        #endregion
    }
    class Employee : Person
    {
        #region Private fields
        private int _militaryTerm;
        #endregion

        #region Public fields
        public int MilitaryTerm
        {
            get { return _militaryTerm; }
            set { _militaryTerm = value; }
        }
        #endregion

        #region Constructors
        public Employee(String Name, int Age, int MilitaryTerm):base(Name, Age)
        {
            _militaryTerm = MilitaryTerm;
        }
        #endregion

        #region Methods
        public override String ToString()
        {
            return base.ToString() + $"; Term of military: {MilitaryTerm}";
        }
        public void DataInput()
        {
            Console.Write("Enter a name: ");
            _militaryTerm = int.Parse(Console.ReadLine());
        }
        #endregion
    }
    class Workman : Person
    {
        #region Private fields
        private String _workPlace;
        #endregion

        #region Public fields
        public String WorkPlace
        {
            get { return _workPlace; }
            set { _workPlace = value; }
        }
        #endregion

        #region Constructors
        public Workman(String Name, int Age, String WorkPlace):base(Name, Age)
        {
            _workPlace = WorkPlace;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + $"; Place of work: {WorkPlace}";
        }
        public void DataInput()
        {
            Console.Write("Enter a name: ");
            _workPlace = Console.ReadLine();
        }
        #endregion
    }
    class Engineer : Person
    {
        #region Private fields
        private String _specialization;
        #endregion

        #region Public fields
        public String Specialization
        {
            get { return _specialization; }
            set { _specialization = value; }
        }
        #endregion

        #region Constructors
        public Engineer(String Name, int Age, String Specialization):base(Name, Age)
        {
            _specialization = Specialization;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString() + $"; Specialization: {Specialization}";
        }
        public void DataInput()
        {
            Console.Write("Enter a name: ");
            _specialization = Console.ReadLine();
        }
        #endregion
    }
}
