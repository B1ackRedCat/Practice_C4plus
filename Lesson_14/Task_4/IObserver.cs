using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal interface IObserver
    {
        void Update(Photographer photographer);
        void Subscribing(Photographer photographer);
        void Unsubscribing(Photographer photographer);
    }
}
