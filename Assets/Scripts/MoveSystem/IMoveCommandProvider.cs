﻿using BoardSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveSystem
{
    public interface IMoveCommandProvider<TPiece> where TPiece : class, IPiece
    {
        List<IMoveCommand<TPiece>> Commands(/*Board<TPiece> board, TPiece piece*/);
    }
}
