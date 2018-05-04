using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution.Interface;

namespace Task3.Solution.Observable
{
    public class Stock : IObservable
    {
        private StockInfo stocksInfo;


        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public event Action<object> NotifyEvent;


        public void Register(IObserver observer)
        {
            NotifyEvent += observer.Update;
        }

        public void Unregister(IObserver observer)
        {
            NotifyEvent -= observer.Update;
        }

        public void Notify()
        {
             NotifyEvent.Invoke(stocksInfo);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
