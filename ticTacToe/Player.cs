namespace ticTacToe
{
    using System;

    public class Player
    {
        private String _name;

        private bool _isWinner;

        private int _leaderBoard;

        public String Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public bool isWiner
        {
            get
            {
                return this._isWinner;
            }
            set
            {
                this._isWinner = value;
            }
        }
        public int leaderBoard
        {
            get
            {
                return this._leaderBoard;
            }
            set
            {
                this._leaderBoard = value;
            }
        }

        public Player()
            : this("unknown", false, 0)
        {

        }
        public Player(String _name, bool _isWiner)
        {
            this._name = _name;
            this._isWinner = _isWiner;
            this._leaderBoard = 0;
        }
        public Player(String _name, bool _isWiner, int _leaderBoard)
        {
            this._name = _name;
            this._isWinner = _isWiner;
            this._leaderBoard = _leaderBoard;
        }
        public override string ToString()
        {
            return this.Name + (this.isWiner ? ", is not win yet." : ", win the game.");
        }
    }
}