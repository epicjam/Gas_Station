using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gas_Station.Car;

namespace Gas_Station
{
    public class CarDriving : IGasStation
    {
        public void Move()
        {

            while (InitLoad > 0)
            {
                InitLoad -= 50;
                Console.WriteLine("Машина едет");
            }
            Console.WriteLine("Бензин кончился. Нужно заправиться");
            Console.WriteLine("Нажмите Enter");
            Refill();
        }

        public void Refill()
        {
            InitLoad += OilCount;
            Console.ReadLine();
            Move();
        }
    }

}
