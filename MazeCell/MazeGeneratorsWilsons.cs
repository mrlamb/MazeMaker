using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRLamb.MazeMaker
{
    public static partial class MazeGenerators
    {
        public static MazeGrid Wilsons(MazeGrid grid)
        {
            Random rnd = new Random();
            grid[rnd.Next(grid.MazeHeight)][rnd.Next(grid.MazeWidth)].InMaze = true;
            do
            {


                //Select random cell to walk from
                //Store starting position for later
                int startX = rnd.Next(grid.MazeHeight);
                int startY = rnd.Next(grid.MazeWidth);
                MazeCell current = grid[startX][startY];

                //Our position as we move around the maze
                int walkingX = startX;
                int walkingY = startY;

                Queue<MazeCell> carvingPath = new Queue<MazeCell>();

                do
                {
                    //If we haven't found the maze yet...
                    if (!current.InMaze)
                    {
                        //Pick a direction and try to move there.
                        switch ((Direction)rnd.Next(3))
                        {
                            case Direction.NORTH:
                                //If we try to walk off the north edge, just break and we'll try again
                                if (walkingX - 1 < 0)
                                    break;
                                else
                                {
                                    //Otherwise, save the last direction we exited to (north in this case)
                                    //And update our position
                                    current.LastExited = Direction.NORTH;
                                    carvingPath.Enqueue(current);
                                    walkingX--;
                                    current = grid[walkingX][walkingY];
                                }
                                break;
                            case Direction.EAST:
                                //If we try to walk off the east edge, just break and we'll try again
                                if (walkingY + 1 > grid[walkingX].Count)
                                    break;
                                else
                                {
                                    //Otherwise, save the last direction we exited to (east in this case)
                                    //And update our position
                                    current.LastExited = Direction.EAST;
                                    carvingPath.Enqueue(current);
                                    walkingY++;
                                    current = grid[walkingX][walkingY];
                                }
                                break;
                            case Direction.SOUTH:
                                //If we try to walk off the south edge, just break and we'll try again
                                if (walkingX + 1 > grid.Count)
                                    break;
                                else
                                {
                                    //Otherwise, save the last direction we exited to (south in this case)
                                    //And update our position
                                    current.LastExited = Direction.SOUTH;
                                    carvingPath.Enqueue(current);
                                    walkingX++;
                                    current = grid[walkingX][walkingY];
                                }
                                break;
                            case Direction.WEST:
                                //If we try to walk off the north edge, just break and we'll try again
                                if (walkingY - 1 < 0)
                                    break;
                                else
                                {
                                    //Otherwise, save the last direction we exited to (north in this case)
                                    //And update our position
                                    current.LastExited = Direction.WEST;
                                    carvingPath.Enqueue(current);
                                    walkingY--;
                                    current = grid[walkingX][walkingY];
                                }
                                break;

                        }
                    }
                    //If we did find the maze, break out of the loop so we can carve our path.
                    else
                    {
                        break;
                    }

                } while (true);

                foreach (var item in carvingPath)
                {
                    //Need to figure out how to carve both walls that are adjacent
                    item.walls[item.LastExited] = false;
                }


            } while (true);

        }
    }
}
