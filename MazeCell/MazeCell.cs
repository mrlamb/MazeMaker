namespace MRLamb.MazeMaker
{
    public class MazeCell
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public bool InMaze { get; set; }
        struct Walls
        {
            public bool North { get; set; }
            public bool East { get; set; }
            public bool South { get; set; }
            public bool West { get; set; }
        }
        public bool Start { get; set; }
        public bool End { get; set; }

    }
}
