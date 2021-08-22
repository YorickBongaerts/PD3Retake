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
    //public class BishopBasicMoveCommand : AbstractBasicMoveCommand
    //{
    //    public BishopBasicMoveCommand(ReplayManager replayManager) : base(replayManager)
    //    {
    //    }

    //    public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        var validTiles = new MovementHelper(board, piece)
    //            .NorthEast()
    //            .SouthEast()
    //            .SouthWest()
    //            .NorthWest()
    //            .GenerateTiles();

    //        return validTiles;
    //    }
    //}
}
