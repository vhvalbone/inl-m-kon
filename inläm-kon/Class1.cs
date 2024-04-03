using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämning_kon
{
    class bil
    {
        public string märke;
        public string model;
        public string tillverkare;
        public string vikt;
        public string pris;

        public void Metod1()
        {
            Console.WriteLine("hej här är lite fakta om fordonet:" + märke + model + tillverkare + vikt + pris);
        }

        public string Märkee;
        public string modell;
        public string tillverkaree;
        public string viktt;
        public string priss;

        public void Metod2()
        {
            Console.WriteLine("Hej är är lite fakta om en annan bil"+Märkee + modell + tillverkaree + viktt + priss);
        }
    }
}

