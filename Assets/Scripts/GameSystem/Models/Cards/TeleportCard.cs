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
        List<Tile> Neighbours(Tile tile, Board<HexenPiece> board)
        {
            var neighbours = new List<Tile>();

            //returns all tiles around the tile which has been given through the parameter
            var validTiles = new HexMovementHelper(board, tile, 1)
                .Radius(1)
                .GenerateTiles();

            //makes sure there are no pieces on the tiles in validtiles
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
        public override List<Tile> Tiles(Tile playerTile, Tile CardTile)
        {
            //make sure both strategies have acces to the board
            List<Tile> NeighbourStrategy(Tile centerTile) => Neighbours(centerTile, _board);
            float DistanceStrategy(Tile fromTile, Tile toTile) => Distance(fromTile, toTile, _board);

            //Create a new pathfinding tool using both strategies. Distance is used twice because heuristics is also a distance
            AStarPathFinding<Tile> aStarPathFinding = new AStarPathFinding<Tile>(NeighbourStrategy, DistanceStrategy, DistanceStrategy);

            return aStarPathFinding.Path(playerTile, CardTile);
        }
    }
}
