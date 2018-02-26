
using System;


namespace GameOfLife
{

    class GameOfLife
    {
        //declare properties of grid
        public int height;
        public int width;

        public bool[,] grid;

        public GameOfLife(int h, int w)
        {

            height = h;
            width = w;
            grid = new bool[h, w];
        }


        //setter and getter for grid
        public bool this[int y, int x]
        {
            get
            {
                return grid[y, x];
            }

            set
            {
                grid[y, x] = value;
            }
        }

        //calculate next generation and set it to new grid
        public void NewGeneration()
        {

            // get new grid for new generation
            bool[,] newgrid = getNewGrid();

            //fill new grid with new generation
            for (var j = 0; j < height; ++j)
            {
                for (var i = 0; i < width; ++i)
                {
                    newgrid[j, i] = getNextState(j, i);
                }
            }

            // assign new grid to old grid
            grid = newgrid;
        }

        // check if cell is out of bound
        private bool isOutOfBounds(int y, int x)
        {
            bool res = false;
            if (y < 0 || y >= height || x < 0 || x >= width)
                res = true;
            return res;
        }

        // find number of alive neighbours
        private int getLiveNeighbours(int y, int x)
        {
            int count = 0;

            //go through each neighbour cell and convert boolean value to integer.If is alive add to count
            for (var j = y - 1; j < y + 2; ++j)
            {
                for (var i = x - 1; i < x + 2; ++i)
                {
                    if (!isOutOfBounds(j, i))
                        count += Convert.ToInt32(grid[j, i]);
                }
            }
           int final_count = count - Convert.ToInt32(grid[y, x]);//substract cell itself
            return final_count ;
        }
        //logic of Game
        //change state of each cell depending on neighbours

        public bool getNextState(int y, int x)
        {
            int count = getLiveNeighbours(y, x);
            if (count == 2)//if number of live neighbours is 2 keep living
            {
                return grid[y,x];
            }
            else if (count == 3)//keep living and live if were dead
            {
                return true;
            }
            else//die in all other cases
            {
                return false;
            }
       
        }
            //generate new grid for new generation 
            public bool[,] getNewGrid()
            {
                bool[,] newgrid = new bool[height, width];//new grid with same dimensions

                for (var j = 0; j < height; ++j)
                {
                    for (var i = 0; i < width; ++i)
                    {

                        newgrid[j, i] = grid[j, i];
                    }
                }

                return newgrid;
            }
        }
    }
