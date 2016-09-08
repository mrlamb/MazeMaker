using System.Collections.Generic;

namespace MRLamb.MazeMaker
{
    public class MazeCell
    {
        public bool InMaze { get; set; }
        public bool Start { get; set; }
        public bool End { get; set; }
        public Direction LastExited { get; set; }
        public Dictionary<Direction, bool> walls = new Dictionary<Direction, bool>();

        public MazeCell()
        {
            
            InMaze = false;
            walls[Direction.NORTH] = true;
            walls[Direction.EAST] = true;
            walls[Direction.SOUTH] = true;
            walls[Direction.WEST] = true;
            Start = false;
            End = false;


        }
    }
   
    public enum Direction
    {
        NORTH, EAST, SOUTH, WEST
    }

}
