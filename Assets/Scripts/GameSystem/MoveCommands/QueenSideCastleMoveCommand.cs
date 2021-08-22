using BoardSystem;
using GameSystem.Models;
using ReplaySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.MoveCommands
{
    //public class QueenSideCastleMoveCommand : AbstractBasicMoveCommand
    //{
    //    public QueenSideCastleMoveCommand(ReplayManager replayManager) : base(replayManager)
    //    {
    //    }

    //    public override bool CanExecute(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        if (piece.HasMoved)
    //            return false;

    //        var tile = board.TileOf(piece);

    //        var rookPosition = tile.Position;
    //        rookPosition.X -= 4;

    //        var rookTile = board.TileAt(rookPosition);
    //        if (rookTile == null)
    //            return false;

    //        var rookPiece = board.PieceAt(rookTile);
    //        if (rookPiece == null || rookPiece.HasMoved)
    //            return false;

    //        var interMediatePosition = tile.Position;
    //        for (int i = 1; i < 4; i++)
    //        {
    //            interMediatePosition.X -= 1;
    //            var intermediateTile = board.TileAt(interMediatePosition);
    //            if (intermediateTile == null)
    //                return false;

    //            var intermediatePiece = board.PieceAt(intermediateTile);
    //            if (intermediatePiece != null)
    //                return false;
    //        }

    //        return true;
    //    }

    //    public override void Execute(Board<ChessPiece> board, ChessPiece piece, Tile toTile)
    //    {
    //        var fromTile = board.TileOf(piece);
            
    //        var rookFromPosition = fromTile.Position;
    //        rookFromPosition.X -= 2;
    //        var rookFromTile = board.TileAt(rookFromPosition);

    //        var rookToPosition = toTile.Position;
    //        rookToPosition.X += 2;
    //        var rookToTile = board.TileAt(rookToPosition);

    //        Action forward = () =>
    //        {
    //            board.Move(fromTile, toTile);
    //            board.Move(rookFromTile, rookToTile);
    //        };
    //        Action backward = () =>
    //        {
    //            board.Move(rookToTile, rookFromTile);
    //            board.Move(toTile, fromTile);
    //        };

    //        var replayCommand = new DelegateReplayCommand(forward, backward);
    //        ReplayManager.Execute(replayCommand);
    //    }

    //    public override List<Tile> Tiles(Board<ChessPiece> board, ChessPiece piece)
    //    {
    //        var tile = board.TileOf(piece);
            
    //        var targetPosition = tile.Position;
    //        targetPosition.X -= 2;
            
    //        var targetTile = board.TileAt(targetPosition);

    //        return new List<Tile>() { targetTile };
    //    }
    //}
}
