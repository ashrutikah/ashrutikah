using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class LotTrenchObstacle
    {
        //public static void Main(string[] args)
        //{
        //    int[,] grid = { { 1, 1, 1, 1 }, { 1, 0, 1, 1 }, { 0, 1, 9, 1 }, { 0, 0, 1, 1 } };
        //    LotTrenchObstacle lt = new LotTrenchObstacle(int, string);
        //    lt.dfs(grid);
        //    Hashtable hs = new Hashtable();


        //    //HashTableArray<TKey, Tvalue> hst = new HashTableArray<TKey, Tvalue>();
            
        //}


        public int countPaths(Boolean[][] grid, int row, int column)
        {
            //if (!validSquare(grid, row, column)) return 0;
            //if (isAtEnd(grid, row, column)) return 1;
            return countPaths(grid, row + 1, column) + countPaths(grid, row, column + 1);
        }
        public void bfs(int[,] grid)
        {
            Queue q = new Queue();
             
            XY xy = new XY();
            xy.x = 0;
            xy.y = 0;
            q.Enqueue(xy);

            while (q.Peek() != null)
            {
                XY xyTemp = (XY)q.Dequeue();


            }
        }

        public void dfs(int[,] grid)
        {            
            int[] posTemp = {0,0};
            List<XY> paths = new List<XY>();
            XY xy = new XY();
            xy.x = 0;
            xy.y = 0;
            paths.Add(xy);
            dfs2(grid, paths,posTemp, 4, 4);
        }
        public void dfs2 (int[,] grid,List<XY> paths,int[] pos,int width,int height)
        {
    int x = pos[0];
    int y = pos[1] ;
    
    int[] posNeighbors = {0,0};
    if (grid[x, y] == 9)
    {
        return;
    }
    if (x - 1 >= 0 && grid[x, y] == 1 && (!paths.Exists(xy1 => xy1.x == x-1 && xy1.y == y))) 
    {
        posNeighbors[0] = x-1;
        posNeighbors[1] = y;
        XY xy = new XY();
        xy.x = x - 1;
        xy.y = y;
        xy.visited = true;
        
            paths.Add(xy);
       
       // xy.visited = true;
        dfs2(grid,paths,posNeighbors,height,width);
    }
    if (y+1 < width && grid[x,y] == 1 && (!paths.Exists(xy1 => xy1.x == x && xy1.y == y+1)))   
    {
        posNeighbors[0] = x;
        posNeighbors[1] = y+1;
        XY xy = new XY();
        xy.x = x;
        xy.y = y+1;
        xy.visited = true;
        
            paths.Add(xy);
       
         dfs2(grid,paths,posNeighbors,height,width);       
    }
    if (x + 1 < height && grid[x, y] == 1 && (!paths.Exists(xy1 => xy1.x == x+1 && xy1.y == y)))
    {
        posNeighbors[0] = x+1;
        posNeighbors[1] = y;
        XY xy = new XY();
        xy.x = x + 1;
        xy.y = y;
        xy.visited = true;
       
            paths.Add(xy);
       
        dfs2(grid,paths,posNeighbors,height,width);
    }

    if (y - 1 >= 0 && grid[x, y] == 1 && (!paths.Exists(xy1 => xy1.x == x && xy1.y == y-1)))
    {
         posNeighbors[0] = x;
        posNeighbors[1] = y-1;
        XY xy = new XY();
        xy.x = x;
        xy.y = y-1;
        xy.visited = true;
        
            paths.Add(xy);
        
        dfs2(grid,paths,posNeighbors,height,width);
    }
        
        //dfs2(grid,(x,y-1),curr,height,width);
        
        }
    }

    public class XY
    {
        public int x;
        public int y;
        public bool visited = false;
        public List<XY> neighbors = new List<XY>();
    }
}
