namespace Tetris.Core
{
    public class Board
    {
        private readonly int _rows;
        private readonly int _columns;

        public Board(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
        }

        public override string ToString()
        {
            var s = string.Empty;
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    s += "?";
                }
                s += "\n";
            }
            return s;
        }
    }
}