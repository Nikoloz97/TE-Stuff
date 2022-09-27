namespace Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; private set; }
        public int PiecesOfFruitLeft { get; private set; }

        public FruitTree (string typeOfFruit, int startingPiecesOfFruitLeft)
        {
            this.TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruitLeft;
        }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if (PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
