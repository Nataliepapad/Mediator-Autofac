using MediatorAutofac.Time.Writters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAutofac.Time.Clocks
{
    public interface IClock
    {
        void PrintTime(IDateWritter writter);
    }
}
