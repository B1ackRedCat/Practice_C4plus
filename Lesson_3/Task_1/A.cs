using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class A
    {
        #region Private fields
        private int _numbA;
        private int _numbB;
        #endregion

        #region Public fields
        public int NumbA
        {
            get { return _numbA; }
            set { _numbA = value; }
        }
        public int NumbB
        {
            get { return _numbB; }
            set { _numbB = value; }
        }
        #endregion

        #region Constructors
        public A(int NumbA, int NumbB)
        {
            _numbA = NumbA;
            _numbB = NumbB;
        }
        #endregion

        #region Methods
        public int CalculateDifference(int NumbA, int NumbB)
        {
            return NumbA - NumbB;
        }

        public double CalculateQuotient(int NumbA, int NumbB)
        {
            return (NumbA + NumbB) / ((NumbA - NumbB));
        }

        public void Print(int NumbA, int NumbB)
        {
            Console.WriteLine("Difference calculation: " + CalculateDifference(NumbA, NumbB));
            Console.WriteLine("Calculation of the quotient: " + CalculateQuotient(NumbA, NumbB));
        }
        #endregion
    }
}
