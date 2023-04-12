using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalsDatabase
{
    internal class ValueRadioBtn : RadioButton
    {
        private int value = 0;
        private String car = " ";

        public void Value(int value) {
            this.value = value; 
        }
        public int Value()
        {
            return value;
        }

        public void CarType(String car)
        {
            this.car = car;
        }
        public String CarType() { return car; }
        
        
    }
}
