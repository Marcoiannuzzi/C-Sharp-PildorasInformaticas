using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circulo
    {
        public double Radio { get; set; } = 5.2;
        public Circulo()
        {

        }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        
        public double CalcularArea()
        {
            return Radio * Radio * Math.PI;
        }

        public double CalcularArea(int radio)
        {
            Radio= radio;
            return Radio * Radio * Math.PI;
        }
    }
}
