namespace Conway_s_Game_of_Life_Blazor.Models
{
    public class Grid
    {
        private Cell[,] gameGrid;
        private int gridX;
        private int gridY;

        public Grid(int x, int y)
        {
            this.GridX = x;
            this.GridY = y;
            this.GameGrid = new Cell[GridX, GridY];
        }
        public int GridX
        {
            get { return gridX; }
            set { gridX = value; }
        }
        public int GridY
        {
            get { return gridY; }
            set { gridY = value; }
        }
        public Cell[,] GameGrid 
        {
            get { return gameGrid; }
            set { gameGrid = value; }
        }
    }
}
