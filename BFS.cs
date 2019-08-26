using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class graphNodes
    {
        public int row;
        public int column;
        public bool visited = false;
        public List<graphNodeN> neighbors = new List<graphNodeN>();

    }

    public class graphNodeN
    {
        public int row;
        public int column;
    }

    class clsBFS
    {
        //public static void Main(string[] args)
        //{
        //    int[,] grid = { { 1, 1, 1, 1,0,0 }, { 0,1, 0, 1, 0,0 }, { 0, 1, 1,1,0, 0 }, { 0, 1, 1,9,0,0 },{0,0,0,0,0,0} };
        //    int row = 4;
        //    int column = 6;
        //    clsBFS clsBfs = new clsBFS();
        //    clsBfs.BFS(grid, row, column);
        //}

        public void BFS(int[,] grid, int row, int column)
        { 
            //Use BFS, queue needs to be use
            //keep a track a visited node
            Queue<graphNodes> qXY = new Queue<graphNodes>();
            List<graphNodes> Paths = new List<graphNodes>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                { 
                    graphNodes objXY = new graphNodes();
                    objXY.row = i;
                    objXY.column = j;
                    objXY.visited = true;                    

                    //Goal reached
                    if (grid[i, j] == 9)
                    {
                        qXY.Enqueue(objXY);
                        return;
                    }
                    else
                    { 
                         //Calculate the neighbors
                        if (i - 1 > 0) //So we can navigate left
                        {
                            if (grid[i - 1, j] == 1)
                            {
                                graphNodeN gn = new graphNodeN();
                                gn.row = i - 1;
                                gn.column = j;
                                objXY.neighbors.Add(gn);
                            }
                        }
                        if (i + 1 < row && grid[i + 1, j] == 1) //So we can navigate right
                        {
                            graphNodeN gn = new graphNodeN();
                            gn.row = i + 1;
                            gn.column = j;
                            objXY.neighbors.Add(gn);
                        }
                        if (j - 1 > 0 && grid[i, j-1] == 1) //So we can navigate up
                        {
                            graphNodeN gn = new graphNodeN();
                            gn.row = i;
                            gn.column = j - 1;
                            objXY.neighbors.Add(gn);
                        }
                        if (j + 1 < column && grid[i, j+1] == 1) //So we can navigate down
                        {
                            graphNodeN gn = new graphNodeN();
                            gn.row = i;
                            gn.column = j + 1;
                            objXY.neighbors.Add(gn);
                        }
                        if(objXY.neighbors.Capacity > 0)
                            qXY.Enqueue(objXY);
                    }
                }
            }
        }
    }
}
