using System;

namespace UppgiftOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Axel", "Gata 10", 17);
            Person person2 = new Person("Petter", "Gata 20", 40);
            Person person3 = new Person("Benjamin", "Gata 30", 20);

            Tärning tärning1 = new Tärning();
            tärning1.kast(7);
        }

       
    }
}
