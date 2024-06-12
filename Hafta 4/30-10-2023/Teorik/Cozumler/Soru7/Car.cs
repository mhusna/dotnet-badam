using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    public class Car
    {

        // Yöntem 2
        public Car(string make)
        {
            Make = make;
        }

        public string Make { get; set; }


        // Yöntem 2
        //public Car(string Make)
        //{
        //    this.Make = Make;
        //}

        //public string Make { get; set; }


        // Yöntem 3
        //public Car(string make)
        //{
        //    _make = make;
        //}

        //private string _make;
        //public string Make { get { return _make; } set { _make = Make; } }
    }

}
