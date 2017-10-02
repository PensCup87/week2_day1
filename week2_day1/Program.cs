using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARING AN ARRAY
            int [] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };
            // 1 is at the Zero Index of the array

            //String Array
            string[] studentNames = {"Katie", "Brian", "JD", "Roy", "Monica", "Ras", "Ali"};

            //Getting Values from Array
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(studentNames[1]);

            //Do It Section
            string [] topVacationSpots = { "Cabo", "Florida Keys", "Hawaii", "Say Juan Taneo", "Virgin Islands", "Italy", "Greece", "Germany", "Catalina Island", "Agusta National" };
            Console.WriteLine(topVacationSpots[0]);
            Console.WriteLine(topVacationSpots[9]);

            int[] childAges = {3, 5, 9};
            Console.WriteLine(childAges[0]);
            Console.WriteLine(childAges[1]);
            Console.WriteLine(childAges[2]);

            float[] studentGPA = {2.3f, 2.9f, 3.1f, 3.3f, 3.7f, 3.9f, 3.97f, 4.0f };
            Console.WriteLine(studentGPA[0]);
            Console.WriteLine(studentGPA[1]);
            Console.WriteLine(studentGPA[2]);
            Console.WriteLine(studentGPA[3]);
            Console.WriteLine(studentGPA[4]);
            Console.WriteLine(studentGPA[5]);
            Console.WriteLine(studentGPA[6]);
            Console.WriteLine(studentGPA[7]);


        }
    }
}
