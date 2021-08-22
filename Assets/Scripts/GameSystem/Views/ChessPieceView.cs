using GameSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameSystem.Views
{
    [SelectionBase]
    public class ChessPieceView : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField]
        PositionHelper _positionHelper = null;

        [SerializeField]
        bool _isLight = true;

        [SerializeField]
        string _movementName = null;

        ChessPiece _model;

        public bool IsLight => _isLight;

        public string MovementName => _movementName;

        public ChessPiece Model {
            get => _model;
            internal set {
                if (_model != null)
                {
                    _model.PieceMoved -= ModelMoved;
                    _model.PieceTaken -= ModelTaken;
                }

                _model = value;

                if (_model != null)
                {
                    _model.PieceMoved += ModelMoved;
                    _model.PieceTaken += ModelTaken;
                }
            } }

        private void ModelTaken(object sender, EventArgs e)
        {
            Destroy(this.gameObject);
        }

        private void ModelMoved(object sender, PieceMovedEventArgs e)
        {
            //var worldPosition = _positionHelper.ToWorldPosition(GameLoop.Instance.Board, e.To.Position);
            //transform.position = worldPosition;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            var board = GameLoop.Instance;

            //board.Select(Model);
        }

        private void OnDestroy()
        {
            Model = null;
        }
    }
}
