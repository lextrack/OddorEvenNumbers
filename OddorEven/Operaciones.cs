using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OddorEven
{
    public class Operaciones
    {
        public bool Primos(long num)
        {
            if (num % 2 == 0)
            {
                MessageBox.Show("This number is even", "Message");
                return true;
            }
            else
            {
                MessageBox.Show("This number is odd", "Message");
                return false;
            }
        }
    }
}

