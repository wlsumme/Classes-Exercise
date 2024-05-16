using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        //Fields    camelCAse

        public int numberOfWheels;
        public bool haveTint;

        // Properties  PascalCase
        public string Make {  get; set; }

        public string Model { get; set; }

        public int year { get; set; }   
    }

    
}
