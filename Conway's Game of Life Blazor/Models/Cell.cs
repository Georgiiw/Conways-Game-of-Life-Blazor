namespace Conway_s_Game_of_Life_Blazor.Models
{
        public record Cell
        {
            private int row;
            private int col;
            private bool isAlive;
            private bool nextState;
            public int Row 
            {
                get { return row; } 
                set { row = value; }
            }
            public int Col
            {
                get { return col; }
                set { col = value; }
            }
            public bool IsAlive
            {
                get { return isAlive; }
                set { isAlive = value; }
            }
            public bool NextState
            {
                get { return nextState; }
                set { nextState = value; }
            }
    }
}
