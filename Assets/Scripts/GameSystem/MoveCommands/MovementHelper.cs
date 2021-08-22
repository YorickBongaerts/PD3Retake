using BoardSystem;
using GameSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.MoveCommands
{
    public class MovementHelper
    {
        public delegate bool Validator(Board<HexenPiece> board, HexenPiece chessPiece, Tile toTile);

        Board<HexenPiece> _board;
        HexenPiece _chessPiece;
        List<Tile> _tiles = new List<Tile>();

        public MovementHelper(Board<HexenPiece> board, HexenPiece chessPiece)
        {
            _board = board;
            _chessPiece = chessPiece;
        }
        public MovementHelper North(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(0, 1, steps, validators);
        }
        public MovementHelper NorthEast(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(1, 1, steps, validators);
        }
        public MovementHelper East(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(1, 0, steps, validators);
        }
        public MovementHelper SouthEast(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(1, -1, steps, validators);
        }
        public MovementHelper South(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(0, -1, steps, validators);
        }
        public MovementHelper SouthWest(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(-1, -1, steps, validators);
        }
        public MovementHelper West(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(-1, 0, steps, validators);
        }
        public MovementHelper NorthWest(int steps = int.MaxValue, params Validator[] validators)
        {
            return Collect(-1, 1, steps, validators);
        }

        public MovementHelper Collect(int x, int y, int steps = int.MaxValue, params Validator[] validators)
        {
            Position MoveNext(Position position)
            {
                //position.X += (_chessPiece.IsLight) ? x : -x;
                //position.Y += (_chessPiece.IsLight) ? x : -y;

                return position;
            }

            var startTile = _board.TileOf(_chessPiece);
            var startPosition = startTile.Position;

            var nextPosition = MoveNext(startPosition);

            int currentStep = 0;

            var blocked = false;

            while (!blocked && currentStep < steps)
            {
                var nextTile = _board.TileAt(nextPosition);
                if (nextTile == null)
                {
                    blocked = true;
                    break;
                }

                var nextPiece = _board.PieceAt(nextTile);
                if (nextPiece != null)
                    blocked = true;

                if ((nextPiece == null/* || _chessPiece.IsLight != nextPiece.IsLight*/) && validators.All(v => v(_board, _chessPiece, nextTile)))
                    _tiles.Add(nextTile);

                nextPosition = MoveNext(nextPosition);
                currentStep++;
            }
            return this;
        }

        public List<Tile> GenerateTiles()
        {
            return new List<Tile>(_tiles);
        }
        public static bool CanCapture(Board<HexenPiece> board, HexenPiece chessPiece, Tile toTile)
        {
            var other = board.PieceAt(toTile);
            return other != null && other != chessPiece;
        }
        public static bool IsEmpty(Board<HexenPiece> board, HexenPiece chessPiece, Tile toTile)
        {
            var other = board.PieceAt(toTile);
            return other == null;
        }
    }
}
