using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> interwovenList = new List<int>();
            if (listTwo.Count > listOne.Count)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (i >= listOne.Count)
                    {
                        interwovenList.Add(listTwo[i]);
                    }
                    else
                    {
                        interwovenList.Add(listOne[i]);
                        interwovenList.Add(listTwo[i]);
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    if (i >= listTwo.Count)
                    {
                        interwovenList.Add(listOne[i]);
                    }
                    else
                    {
                    interwovenList.Add(listOne[i]);
                    interwovenList.Add(listTwo[i]);
                    }
                }
            }
            
            return interwovenList;
        }
    }
}
