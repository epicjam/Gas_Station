using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station
{
    public class Car
    {
        public interface IGasStation
        {
            void Move();
            void Refill();
        }
        public static int InitLoad { get; set; }
        public static int OilCount { get; set; }
        public Car(int initLoad, int oilCount)
        {
            InitLoad = initLoad;
            OilCount = oilCount;
        }


    }

}
