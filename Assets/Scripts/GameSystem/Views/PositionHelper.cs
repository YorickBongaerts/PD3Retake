using UnityEngine;
using BoardSystem;
using GameSystem.Utils;

namespace GameSystem.Views
{
    [CreateAssetMenu(fileName = "DefaultPositionHelper", menuName = "GameSystem/PositionHelper")]
    public class PositionHelper : ScriptableObject
    {
        [SerializeField]
        private Vector3 _tileSize = Vector3.one;

        [SerializeField]
        private float _radius = 0.5f;

        public Vector3 TileSize => _tileSize;

        public float Radius => _radius;

        //public Position ToBoardPosition(Board<ChessPiece> board, Vector3 worldPosition)
        //{
        //    var boardSize = Vector3.Scale(board.AsVector3(), TileSize);

        //    var boardOffset = (TileSize - boardSize / 2);
        //    boardOffset.y = 0;

        //    var offset = worldPosition - boardOffset;

        //    var boardPosition = new Position
        //    {
        //        X = (int)( Mathf.Round(offset.x*2)/2 / TileSize.x),
        //        Y = (int)( Mathf.Round(offset.z*2)/2 / TileSize.z)
        //    };

        //    return boardPosition;
        //}

        public Position ToBoardPosition(Vector3 localPosition)
        {
            float[] hex = HexagonHelper.PixelToPointyHex(localPosition.x, localPosition.z, _radius);
            return new Position() { X = (int)hex[0], Y = (int)hex[1], Z = (int)hex[2] };
        }

        //public Vector3 ToWorldPosition(Board<HexenPiece> board, Position boardPosition)
        //{
        //    var boardSize = Vector3.Scale(board.AsVector3(), TileSize);

        //    var boardOffset = (TileSize - boardSize / 2);
        //    boardOffset.y = 0;

        //    var tilePosition = boardOffset + Vector3.Scale(boardPosition.AsVector3(), TileSize);

        //    return tilePosition;
        //}
        public Vector3 ToWorldPosition(Transform transform, Position position)
        {
            Vector3 localPosition = ToLocalPosition(position);
            return transform.localToWorldMatrix * localPosition;
        }
        public Vector3 ToLocalPosition(Position boardPosition)
        {
            float[] pos = HexagonHelper.PointyHexToPixel(boardPosition.X, boardPosition.Z, _radius);
            return new Vector3(pos[0], 0f, pos[1]);
        }

    }
}
