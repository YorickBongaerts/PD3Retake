using GameSystem.Models;
using GameSystem.MoveCommands;
using GameSystem.States;
using GameSystem.Utils;
using MoveSystem;
using ReplaySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.MoveCommandProviders
{
    [MoveCommandProvider(KnightMoveCommandProvider.Name)]
    class KnightMoveCommandProvider : AbstractMoveCommandProvider
    {
        public const string Name = "Knight";

        public KnightMoveCommandProvider(PlayGameState playGameState, ReplayManager replayManager) : base(playGameState/*, new KnightBasicMoveCommand(replayManager)*/) { }
    }
}
