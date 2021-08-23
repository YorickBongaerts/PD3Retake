using BoardSystem;
using DeckSystem.Utils;
using GameSystem.MoveCommands;
using GameSystem.Utils;
using System.Collections.Generic;

namespace GameSystem.Models.Cards
{
    [CardName("Teleport")]
    public class TeleportCard : CardBase
    {
        private Board<HexenPiece> _board;
        public TeleportCard(Board<HexenPiece> board) : base(board)
        {
            _board = board;
        }

        public override void OnMouseReleased(Tile playerTile, Tile focusedTile)
        {
            if (Tiles(playerTile, focusedTile).Contains(focusedTile))
                Board.Move(playerTile, focusedTile);
        }

        public override List<Tile> Tiles(Tile playerTile, Tile CardTile)
        {
            List<Tile> NeighbourStrategy(Tile centerTile) => Neighbours(centerTile, _board);

            float DistanceStrategy(Tile fromTile, Tile toTile) => Distance(fromTile, toTile, _board);

            AStarPathFinding<Tile> aStarPathFinding = new AStarPathFinding<Tile>(NeighbourStrategy, DistanceStrategy, DistanceStrategy);

            return aStarPathFinding.Path(playerTile, CardTile);
        }

        List<Tile> Neighbours(Tile tile, Board<HexenPiece> board)
        {
            var neighbours = new List<Tile>();

            var validTiles = new HexMovementHelper(board, tile, 1)
                .Radius(1)
                .GenerateTiles();

            foreach (var validTile in validTiles)
            {
                if (validTile != null && board.PieceAt(validTile) == null)
                    neighbours.Add(validTile);
            }

            return neighbours;
        }

        float Distance(Tile fromTile, Tile toTile, Board<HexenPiece> board)
        {
            var fromPosition = fromTile.Position;
            var toPosition = toTile.Position;

            var totalDistance = HexagonHelper.Distance(fromPosition.X, fromPosition.Y, fromPosition.Z, toPosition.X, toPosition.Y, toPosition.Z);

            return totalDistance;
        }
    }
}
