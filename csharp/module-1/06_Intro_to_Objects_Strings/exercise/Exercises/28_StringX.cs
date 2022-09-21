namespace Exercises
{
    public partial class StringExercises
    {

        /*Given a string, return a version where all the "x" have been removed.Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"*/



        
        public string StringX(string str)
        {
            char splitter = '0';

            char[] strArray = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                strArray[i] = str[i];

            }
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (strArray[i] == 'x')
                {
                    strArray[i] = splitter;
                }
                

            }
            string midArray = string.Join("", strArray);
            string[] finalArray = midArray.Split('0');
            string finalAnswer = string.Join("", finalArray);

            return finalAnswer;
        }

        
    }
 
}
