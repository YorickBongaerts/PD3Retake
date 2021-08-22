using BoardSystem;
using GameSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameSystem.Views
{
    [CreateAssetMenu(fileName = "DefaultHexenPieceViewFactory", menuName = "GameSystem/HexenPieceView Factory")]
    public class HexenPieceViewFactory : ScriptableObject
    {
        //[SerializeField]
        //List<PlayerView> _pieceViews = null;

        [SerializeField]
        List<string> _movementNames = new List<string>();

        [SerializeField]
        PlayerView _prefab = null;

        [SerializeField]
        private PositionHelper _positionHelper = null;

        public PlayerView CreateHexenPieceView(Board<HexenPiece> board, HexenPiece model, string movementName)
        {
            //return null;
            //var list = model.IsLight ? _lightChessPieceViews : _darkChessPieceViews;
            //var index = _movementNames.IndexOf(movementName);

            //var prefab = list[index];
            var hexenPieceView = Instantiate(_prefab);

            var tile = board.TileOf(model);
            //hexenPieceView.transform.position = _positionHelper.ToWorldPosition(board, tile.Position);
            hexenPieceView.name = $"Spawned HexenPiece ( { movementName } )";
            hexenPieceView.Model = model;

            return hexenPieceView;
        }
    }
}
