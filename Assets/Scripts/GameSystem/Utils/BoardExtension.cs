﻿using BoardSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GameSystem.Utils
{
    public static class BoardExtension
    {
        public static Vector3 AsVector3<TPiece>(this Board<TPiece> board) where TPiece : class, IPiece
        {
            return new Vector3(board.Columns, 1, board.Rows);
        }
    }
}
