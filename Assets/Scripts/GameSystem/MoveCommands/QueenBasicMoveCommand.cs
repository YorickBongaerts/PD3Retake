using BoardSystem;
using GameSystem.Models;
using MoveSystem;
using ReplaySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.MoveCommands
{
    //public class QueenBasicMoveCommand : AbstractBasicMoveCommand
    //{
    //    public QueenBasicMoveCommand(ReplayManager replayManager) : base(replayManager)
    //    {
    //    }

    //    public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        var validTiles = new MovementHelper(board, piece)
    //            .North()
    //            .NorthEast()
    //            .East()
    //            .SouthEast()
    //            .South()
    //            .SouthWest()
    //            .West()
    //            .NorthWest()
    //            .GenerateTiles();

    //        return validTiles;
    //    }
    //}
}
