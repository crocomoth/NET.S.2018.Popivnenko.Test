using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution.Interface
{
    public interface IObservable
    {
        event Action<object> NotifyEvent; 

        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }
}
