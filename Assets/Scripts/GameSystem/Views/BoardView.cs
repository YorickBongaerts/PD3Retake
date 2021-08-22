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
    public class BoardView : MonoBehaviour
    {
        [SerializeField]
        TileViewFactory _tileViewFactory;

        //[SerializeField]
        //ChessPieceViewFactory _chessPieceViewFactory = null;

        [SerializeField]
        HexenPieceViewFactory _hexenPieceViewFactory = null;

        private void Start()
        {
            var gameLoop = GameLoop.Instance;

            gameLoop.Initialized += OnGameInitialized;
        }

        private void OnGameInitialized(object sender, EventArgs e)
        {
            var gameLoop = GameLoop.Instance;
            var board = gameLoop.Board;

            board.PiecePlaced += OnPiecePlaced;
        }

        private void OnPiecePlaced(object sender, PiecePlacedEventArgs<HexenPiece> e)
        {
            //if (!((Board<IPiece>)sender).HexTiles)
            //{
            //    //var board = sender as Board<ChessPiece>;

            //    //var piece = e.Piece;

            //    //var gameLoop = GameLoop.Instance;
            //    //var movementManager = gameLoop.MoveManager;
            //    //var movementName = movementManager.MovementOf(piece);

            //    //_chessPieceViewFactory.CreateChessPieceView(board, piece, movementName);
            //}
            //else
            //{
                var board = sender as Board<HexenPiece>;

                var piece = e.Piece;

                var gameLoop = GameLoop.Instance;
                var movementManager = gameLoop.MoveManager;
                var movementName = movementManager.MovementOf(piece);

                _hexenPieceViewFactory.CreateHexenPieceView(board, piece, movementName);
            //}

            // Create the right piece and put it on the tile
        }
    }
}
