using System;
namespace Game
{

  class Board
  {
    // New Board with Columns and Rows
    int rows;
    int columns;

    public Board(int r, int c)
    {
      this.rows = r;
      this.columns = c;
    }

    public void drawBoard()
    {


      Console.WriteLine("Rows: " + this.rows + " Columns: " + this.columns);

      for (int i = 0; i < this.rows; i++)
      {
        for (int j = 0; j < this.columns; j++)
        {
          Console.Write("--");
          if (j != this.columns - 1)
          {
            Console.Write("|");
          }
        }

        Console.WriteLine();
      }

    }

  }

}