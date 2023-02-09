﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac.Time.Writters
{
    public class FullDateWritter : IDateWritter
    {
        public void Write(DateTime date)
        {
            Console.WriteLine(date.ToLongDateString());
        }
    }
}