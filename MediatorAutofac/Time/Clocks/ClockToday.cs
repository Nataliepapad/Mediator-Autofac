using MediatorAutofac.Time.Writters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac.Time.Clocks

{
    public class ClockToday : IClock
    {
        private IDateWritter _dateWritter;

        public ClockToday(IDateWritter dateWritter) { 
            _dateWritter = dateWritter; 
        }

        public void PrintTime(IDateWritter writter)
        {
            var now = DateTime.Now;
            _dateWritter.Write(now);
        }
    }
}
