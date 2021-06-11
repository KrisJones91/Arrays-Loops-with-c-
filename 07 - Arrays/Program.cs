using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }
            //ALWAYS an "int" when doing a for loop ***<<<<<
            //performance: for loop works more efficiently for storage
            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            //ALWAYS the data type of the array in forEach "int k" ****<<<<< BELOW you can see "string name" being used
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
            }

            Console.ReadKey();

            // Create an array with the names of five friends
            // greet all of them with a foreach loop

            string[] myFriends = { "Michael", "Wlad", "Ilja", "Andy", "Daniel" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my friend", name);
            }

            Console.ReadKey();

            //SAMPLE SOLUTION for SWITCH STATEMENTS

            Boolean valid = false;
            string inputValueType;
            //different way of doing the above for the below version
            // string inputValueType = string.Empty;

            Console.Write("Enter a value : ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for a String.");
            Console.WriteLine("Press 2 for an Integer.");
            Console.WriteLine("Press 3 for a Boolean.");

            Console.Write("Enter: ");
            int inputType = Convert.ToInt32(Console.ReadLine());
            //Want to know what the user decided to input
            switch (inputType)
            {
                case 1:
                //Check for string by creating a method -- outside the static main
                    valid = isAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    Boolean retFlag = false;
                    //check for boolean
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    //can do this 2 different ways : go to top of file to see different way
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect input type, something went wrong");
                    break;
            }

            Console.WriteLine("You have entered a value : {0}", inputValue);
            if(valid)
            {
                Console.WriteLine("It is valid : {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is invlaid : {0}", inputValueType);
            }
            Console.ReadKey();
        }

        // creating method for isAllAlphabetic
        //static because we are not creating an object of this class + calling it in "static Main" so must also be static
        static bool isAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if(!char.IsLetter(c))
                return false;
            }
            return true;
        }

    }
}
