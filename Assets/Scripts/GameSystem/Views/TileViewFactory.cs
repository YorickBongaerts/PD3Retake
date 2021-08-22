﻿using BoardSystem;
using GameSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameSystem.Views
{
    [CreateAssetMenu(fileName = "DefaultTileViewFactory", menuName = "GameSystem/TileView Factory")]
    public class TileViewFactory : ScriptableObject
    {
        //[SerializeField]
        //TileView _darkTileView = null;

        //[SerializeField]
        //TileView _lightTileView = null;

        [SerializeField]
        TileView _hexTileView = null;

        [SerializeField]
        PositionHelper _positionHelper = null;

        public TileView CreateTileView(Board<HexenPiece> board, Tile tile, Transform parent, bool isChessBoard = true)
        {
            //var position = Vector3.zero;
            //if (isChessBoard)
            //    position = _positionHelper.ToWorldPosition(board, tile.Position);
            //else
            var position = _positionHelper.ToLocalPosition(tile.Position);

            //var prefab = new TileView();

            //if (isChessBoard)
            //    prefab = ((tile.Position.X + tile.Position.Y) % 2) == 0 ? _darkTileView : _lightTileView;
            //else
            var prefab = _hexTileView;

            var tileView = GameObject.Instantiate<TileView>(prefab, position, Quaternion.identity, parent);

            //if (isChessBoard)
            //{
            //    tileView.Size = _positionHelper.TileSize;

            //    tileView.name = $"Tile {(char)(65 + tile.Position.X)}{tile.Position.Y + 1}";
            //}
            //else
            //{
                tileView.Radius = _positionHelper.Radius;

                
                tileView.name = $"Tile {tile.Position.X}, {tile.Position.Y}, {tile.Position.Z}";
            //}

            tileView.Model = tile;

            return tileView;
        }
    }
}
