using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardSystem;
using GameSystem.Views;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace GameSystem.Models
{
    public class ChessPiece : PieceBase
    {
        public bool HasMoved { get; set; }
        public bool IsLight { get; }

        public ChessPiece(bool isLight)
        {
            IsLight = isLight;
        }
    }
}
