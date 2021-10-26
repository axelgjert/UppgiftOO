using System;
using System.Collections.Generic;
using System.Text;

namespace UppgiftOO
{
    class Person
    {
        private string Namn;
        private string Adress;
        private int Ålder;

        public Person(string aNamn, string aAdress, int aÅlder)
        {
            Namn = aNamn;
            Adress = aAdress;
            Ålder = aÅlder;

            Console.WriteLine($"Jag heter {Namn} och jag är {Ålder} år gammal och jag bor på {Adress}");
        }
         
     public string aNamn
        {
            get { return Namn;  }
            set { Namn = value; }
        }
    
     public string aAdress
        {
            get { return Adress; }
            set { Adress = value; }
        }
  

    public int aÅlder
    {
            get { return Ålder;  }
            set { Ålder = value; }
    }

    }

  
}
