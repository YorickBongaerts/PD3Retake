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
    //public class KnightBasicMoveCommand : AbstractBasicMoveCommand
    //{
    //    public KnightBasicMoveCommand(ReplayManager replayManager) : base(replayManager)
    //    {
    //    }

    //    public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        var validTiles = new MovementHelper(board, piece)
    //            .Collect(2, 1, 1)
    //            .Collect(2, -1, 1)
    //            .Collect(-2, 1, 1)
    //            .Collect(-2, -1, 1)
    //            .Collect(1, 2, 1)
    //            .Collect(1, -2, 1)
    //            .Collect(-1, 2, 1)
    //            .Collect(-1, -2, 1)
    //            .GenerateTiles();

    //        return validTiles;
    //    }
    //}
}
