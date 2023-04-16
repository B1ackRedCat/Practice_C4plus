using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_4
{
    internal class StringArray
    {
        #region Private fields
        private string[,] _array;
        private int _row;
        private int _column;
        private int _length;
        #endregion

        #region Public fields
        public string this[int row, int column]
        {
            get { return _array[row, column]; }
            set
            {
                if (value.Length == _length)
                    _array[row, column] = value;
                else
                    throw new ArgumentException("Invalid length of string.");
            }
        }
        #endregion

        #region Constructors
        public StringArray(int row, int column, int length)
        {
            _array = new string[row, column];
            _row = row;
            _column = column;
            _length = length;
        }
        #endregion

        #region Methods
        public void GenerateArray()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[_length];
            Random random = new Random();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    for (int k = 0; k < stringChars.Length; k++)
                    {
                        stringChars[k] = chars[random.Next(chars.Length)];
                    }
                    _array[i, j] = new string(stringChars);
                }
            }
        }

        public static bool operator !=(StringArray stringArray1, StringArray stringArray2)
        {
            return !Enumerable.Range(0, stringArray1._array.Rank).All(dimension => stringArray1._array.GetLength(dimension) == stringArray2._array.GetLength(dimension)) && stringArray1._array.Cast<string>().SequenceEqual(stringArray2._array.Cast<string>());
            /*if (stringArray1._row == stringArray2._row && stringArray1._column == stringArray2._column)
            {
                for (int i = 0; i < stringArray1._row; i++)
                {
                    for (int j = 0; j < stringArray1._column; j++)
                    {
                        if (stringArray1[i, j] == stringArray2[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true; //это способ поэлементного сравнения*/
        }

        public static bool operator ==(StringArray stringArray1, StringArray stringArray2)
        {
            return Enumerable.Range(0, stringArray1._array.Rank).All(dimension => stringArray1._array.GetLength(dimension) == stringArray2._array.GetLength(dimension)) && stringArray1._array.Cast<string>().SequenceEqual(stringArray2._array.Cast<string>());
            /*if (stringArray1._row == stringArray2._row && stringArray1._column == stringArray2._column)
            {
                for (int i = 0; i < stringArray1._row; i++)
                {
                    for (int j = 0; j < stringArray1._column; j++)
                    {
                        if (stringArray1[i, j] != stringArray2[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true; //это способ поэлементного сравнения*/
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    sb.Append($"{_array[i, j]} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        #endregion
    }
}
