﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    class Car
    {
        public int year;
        public string make;
        public string colour;
        public int mileage;

        public Car(int _year, string _make, string _colour, int _mileage)
        {
            year = _year;
            make = _make;
            colour = _colour;
            mileage = _mileage;
        }
    }

}
