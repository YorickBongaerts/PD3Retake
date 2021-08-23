using GameSystem.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace BoardSystem.Editor
{
    //[CustomEditor(typeof(BoardView))]
    //public class BoardViewEditor : UnityEditor.Editor
    //{
    //    string _rows = "8";
    //
    //    string _columns = "8";
    //
    //    string _radius = "3";
    //
    //    public override void OnInspectorGUI()
    //    {
    //        base.OnInspectorGUI();
    //
    //        // Chess board
    //        if (GUILayout.Button("Create chessboard"))
    //        {
    //            _rows = "8";
    //            _columns = "8";
    //            CreateBoard(true);
    //        }
    //
    //        _rows = GUILayout.TextField(_rows, 3);
    //        _columns = GUILayout.TextField(_columns, 3);
    //        // Custom board
    //        if (GUILayout.Button("Create custom board"))
    //        {
    //            CreateBoard(true);
    //        }
    //
    //        _radius = GUILayout.TextField(_radius, 3);
    //        // Hex board
    //        if (GUILayout.Button("Create hexenboard"))
    //        {
    //            CreateBoard(false);
    //        }
    //    }
    //
    //    private void CreateBoard(bool isChessBoard)
    //    {
    //        var boardView = target as BoardView;
    //
    //        var tileViewFactorySp = serializedObject.FindProperty("_tileViewFactory");
    //        var tileViewFactory = tileViewFactorySp.objectReferenceValue as TileViewFactory;
    //
    //        var game = GameLoop.Instance;
    //
    //        game.CreateBoard(int.Parse(_rows), int.Parse(_columns), isChessBoard ? -1 : int.Parse(_radius));
    //        var board = game.Board;
    //
    //        foreach (var tile in board.Tiles)
    //        {
    //            tileViewFactory.CreateTileView(board, tile, boardView.transform, isChessBoard);
    //        }
    //    }
    //}
}
