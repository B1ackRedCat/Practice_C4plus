﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal class CenterFlat : Flat
    {
        private string districtName;

        public string DistrictName { get => districtName; set => districtName = value; }

        public CenterFlat(string distName, string name, double cost, double square) : base(name, cost, square)
        {
            DistrictName = distName;
        }

        public override string[] WritePars() => new[] { DistrictName, Name, CostPerSquareMeter.ToString(), Square.ToString() };
        public override double GetApartmentCost() => base.GetApartmentCost() + (base.GetApartmentCost() * 0.01 / 100);
    }
}
