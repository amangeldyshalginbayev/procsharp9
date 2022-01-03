namespace SimpleIndexer
{
    public class SomeContainer
    {
        private int[,] my2DintArray = new int[10, 10];

        public int this[int row, int column]
        {
            get => my2DintArray[row,column];
            set => my2DintArray[row, column] = value;
        }
    }
}