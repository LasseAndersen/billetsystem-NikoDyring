﻿using System;

namespace BilletLib
{
    public abstract class Vehicle
    {

        public abstract string Nummerplade { get; }
        public abstract DateTime Dato { get; }
        public abstract int Pris();
        public abstract string TypeAfKøretøj();

    }
}