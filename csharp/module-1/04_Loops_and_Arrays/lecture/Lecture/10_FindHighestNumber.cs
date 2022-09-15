namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highestNumber = randomNumbers[0];
            for (int i = 1; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > randomNumbers[i - 1])
                {
                    highestNumber = randomNumbers[i];
                }
                continue;
            }
            return highestNumber;
        }


       /* public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highestNumber = randomNumbers[0];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int currentValue = randomNumbers[i];
                if (currentValue > highestNumber)
                {
                    highestNumber = currentValue;
                }

            }
            return highestNumber;
        }*/


    }
}
