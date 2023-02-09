using MediatorAutofac.Time.Writters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac.Time.Clocks
{
    public class ClockTomorrow : IClock
    {
        public IDateWritter _dateWritter { get; }

        public ClockTomorrow(IDateWritter dateWritter)
        {
            _dateWritter = dateWritter;
        }

        public void PrintTime(IDateWritter writter)
        {
            var now = DateTime.Now.AddDays(1);
            _dateWritter.Write(now);
        }
    }
}
