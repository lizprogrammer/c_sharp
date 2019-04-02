using System;
namespace Game{
  
  class Game
    {
      public struct position
      {
        public int xCoord;
        public int yCoord;
        public bool isOccupied;
      }
      
      Board myBoard;
      
    public void loadMoves(){
      this.myBoard = new Board(4,4);
      this.myBoard.drawBoard();

      position[] moves = new position[16];

      for(int i = 0; i < moves.Length;i++)
      {
        moves[i].xCoord = i;
        moves[i].yCoord = i;
        moves[i].isOccupied = false;
        Console.WriteLine(i);
      }

    }
  }
}
