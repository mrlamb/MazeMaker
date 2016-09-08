using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRLamb.MazeMaker
{
    public class MazeGrid : List<List<MazeCell>>
    {
        public int MazeHeight { get; private set; }
        public int MazeWidth { get; private set; }
        
        public MazeGrid(int height, int width)
        {
            MazeHeight = height;
            MazeWidth = width;


            for (int i = 0; i < MazeHeight; i++)
            {
                this.Add(new List<MazeCell>());
                for (int j = 0; j < MazeWidth; j++)
                {
                    this[i].Add(new MazeCell());
                }

            }

        }
    }
}
