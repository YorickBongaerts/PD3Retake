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
    //public class KingBasicMoveCommand : AbstractBasicMoveCommand
    //{
    //    public KingBasicMoveCommand(ReplayManager replayManager) : base(replayManager)
    //    {
    //    }

    //    public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        var validTiles = new MovementHelper(board, piece)
    //            .North(1)
    //            .NorthEast(1)
    //            .East(1)
    //            .SouthEast(1)
    //            .South(1)
    //            .SouthWest(1)
    //            .West(1)
    //            .NorthWest(1)
    //            .GenerateTiles();

    //        return validTiles;
    //    }
    //}
}
