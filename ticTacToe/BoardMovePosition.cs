namespace ticTacToe
{
    public class BoardMovePosition
    {
        public int X { get; set; }

        public int Y { get; set; }

        public BoardMovePosition()
            : this(-1, -1)
        {
            
        }

        public BoardMovePosition(int _x, int _y)
        {
            this.X = _x;
            this.Y = _y;
        }

        public override string ToString()
        {
            return "X : " + this.X + " Y : " + this.Y;
        }
    }
}