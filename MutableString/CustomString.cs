using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableString
{
    public class CustomString
    {
        private char[] PermanentArray;
        public CustomString(string thingToWorkWith)
        {
            PermanentArray = new char[thingToWorkWith.Length];
            for (int i = 0; i < thingToWorkWith.Length; i++)
            {
                PermanentArray[i] = thingToWorkWith[i];
            }
            //or
            //PermanentArray = thingToWorkWith.ToCharArray(); 
        }

        public void ToUpper()
        {
            for (int i = 0; i < PermanentArray.Length; i++)
            {
                if (PermanentArray[i] > 96 && PermanentArray[i] < 123) //are lower case
                {
                    PermanentArray[i] = (char)(PermanentArray[i] - 32);
                }
                if (PermanentArray[i] < 91 && PermanentArray[i] > 64)
                {
                    PermanentArray[i] = (char)(PermanentArray[i]);
                }
                Console.WriteLine(PermanentArray[i]);
            }
        }

        public void ToLower()
        {
            for (int i = 0; i < PermanentArray.Length; i++)
            {
                if (PermanentArray[i] > 96 && PermanentArray[i] < 123)
                {
                    PermanentArray[i] = (char)(PermanentArray[i]);
                }
                if (PermanentArray[i] < 91 && PermanentArray[i] > 64)
                {
                    PermanentArray[i] = (char)(PermanentArray[i] + 32);
                }
                Console.WriteLine(PermanentArray[i]);
            }
        }

        public bool Contains(string thingThatWeAreLookingFor)
        {
            char[] tempArray = new char[thingThatWeAreLookingFor.Length];
            tempArray = thingThatWeAreLookingFor.ToCharArray();
            for (int i = 0; i < PermanentArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length; j++)
                {
                    if (tempArray[j] == PermanentArray[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Split(char thingToSplitWith)
        {
            //NOT FINISHED
            List<char> tempList = new List<char>();
            foreach (char item in PermanentArray)
            {
                if (item == thingToSplitWith)
                {
                    tempList.Add(item);
                }
            }
        }


        public void Count()
        {
            int counter = 0;
            foreach (char item in PermanentArray)
            {
                counter += 1;
            }
            Console.WriteLine(counter);
        }

        //or

        public int Count(string thingToCount)
        {
            int counter = 0;
            foreach (char item in thingToCount)
            {
                counter += 1;
            }
            return counter;
        }

        public void Replace(char newThing)
        {
            //NOT FINISHED
            //char[] tempArray = new char[newThing];
            //tempArray = newThing.ToCharArray();
            for (int i = 0; i < PermanentArray.Length; i++)
            {
                if(PermanentArray[i] != newThing)
                {
                    PermanentArray[i] = newThing;
                    Console.WriteLine(PermanentArray[i]);
                }
                //need to replace a specific index in PermanentArray
                Console.WriteLine(PermanentArray[i] + "Outside if statement");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
