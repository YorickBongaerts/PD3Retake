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
    [CreateAssetMenu(fileName = "DefaultChessPieceViewFactory", menuName = "GameSystem/ChessPieceView Factory")]
    public class ChessPieceViewFactory : ScriptableObject
    {
        //[SerializeField]
        //List<ChessPieceView> _darkChessPieceViews = null;

        //[SerializeField]
        //List<ChessPieceView> _lightChessPieceViews = null;

        [SerializeField]
        List<string> _movementNames = new List<string>();

        //[SerializeField]
        //private PositionHelper _position = null;

        public ChessPieceView CreateChessPieceView(Board<ChessPiece> board, ChessPiece model, string movementName)
        {
            return null;
            //var list = model.IsLight ? _lightChessPieceViews : _darkChessPieceViews;
            //var index = _movementNames.IndexOf(movementName);

            //var prefab = list[index];
            //var chessPieceView = GameObject.Instantiate<ChessPieceView>(prefab);

            //var tile = board.TileOf(model);
            //chessPieceView.transform.position = _position.ToWorldPosition(board, tile.Position);
            //chessPieceView.name = $"Spawned ChessPiece ( { movementName } )";
            //chessPieceView.Model = model;

            //return chessPieceView;
        }
    }
}
