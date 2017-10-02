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
            ////DECLARING AN ARRAY
            //int [] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };
            //// 1 is at the Zero Index of the array

            ////String Array
            //string[] studentNames = {"Katie", "Brian", "JD", "Roy", "Monica", "Ras", "Ali"};

            ////Getting Values from Array
            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[1]);

            ////Do It Section
            //string [] topVacationSpots = { "Cabo", "Florida Keys", "Hawaii", "Say Juan Taneo", "Virgin Islands", "Italy", "Greece", "Germany", "Catalina Island", "Agusta National" };
            //Console.WriteLine(topVacationSpots[0]);
            //Console.WriteLine(topVacationSpots[9]);

            //int[] childAges = {3, 5, 9};
            //Console.WriteLine(childAges[0]);
            //Console.WriteLine(childAges[1]);
            //Console.WriteLine(childAges[2]);

            //float[] studentGPA = {2.3f, 2.9f, 3.1f, 3.3f, 3.7f, 3.9f, 3.97f, 4.0f };
            //Console.WriteLine(studentGPA[0] + " " + studentGPA[1] + " " + studentGPA[2]);
            //Console.WriteLine(studentGPA[3]);
            //Console.WriteLine(studentGPA[4]);
            //Console.WriteLine(studentGPA[5]);
            //Console.WriteLine(studentGPA[6]);
            //Console.WriteLine(studentGPA[7]);

            ////Addeing Values to Array - Declaring and Empyt Array

            //int[] numbers = new int[4];
            ////Creates an int array that can store 4 values and TYPE Is Specific
            //// new int is used to create an array where elements are not known
            //numbers[0] = 43;
            ////adds the stated value to the specified index
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter another number");
            //numbers[3] = int.Parse(Console.ReadLine());

            ////Changing Array Values
            //numbers[0] = 30;
            ////Replaces 43 with 30


            ////Declaring and initializing a New String
            //string[] daysOfWeek = new string[7];
            //daysOfWeek[0] = "Monday";
            //daysOfWeek[1] = "Tuesday";
            //daysOfWeek[2] = "Wednesday";
            //daysOfWeek[3] = "Thursday";
            //daysOfWeek[4] = "Friday";
            //daysOfWeek[5] = "Saturday";
            //daysOfWeek[6] = "Sunday";

            ////Declaring and initializing another Array
            //int[] studentAges = new int[5];
            //studentAges[0] = 20;
            //studentAges[1] = 21;
            //studentAges[2] = 36;
            //studentAges[4] = 30;
            //studentAges[5] = 47;

            string[] myLastName = new string[4];
            myLastName[0] = "T";
            myLastName[1] = "o";
            myLastName[2] = "m";
            myLastName[3] = "e";

            Console.WriteLine(myLastName.Length);
            
            string[] anArray = { "red", "black", "green", "orange", "gold" };
            //Counts the number of Elements in the ARRAY USING LENGTH PROPERTY
            //If you take the LENGTH of an Array -1 is the last Element
            //Finding the 2nd to last Element of the Array with Length Property

            //.Length - 1 = Last Element Index
            //[] indicate Index and Calculating the Lenght will cause an error
            //because length is one more than index count
            //to avoid errors use Length - 1
            int index = anArray.Length;
            index = index - 2;
            Console.WriteLine(anArray[index]);



        }
    }
}
