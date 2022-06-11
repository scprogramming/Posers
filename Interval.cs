using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posers
{
    public class Interval
    {
        private int quantity;
        private int time;
        private string unit;

        public Interval()
        {
            quantity = 0;
            time = 0;
            unit = "";
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int getTime()
        {
            return time; 
        }

        public void setTime(int time)
        {
            this.time = time;
        }

        public string getUnit()
        {
            return unit;
        }

        public void setUnit(string unit)
        {
            this.unit = unit;
        }

    }
}
