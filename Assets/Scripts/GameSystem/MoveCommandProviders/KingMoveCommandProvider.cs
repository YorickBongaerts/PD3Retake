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
    [MoveCommandProvider(KingMoveCommandProvider.Name)]
    class KingMoveCommandProvider : AbstractMoveCommandProvider
    {
        public const string Name = "King";

        public KingMoveCommandProvider(PlayGameState playGameState, ReplayManager replayManager) : base(playGameState/*, new KingBasicMoveCommand(replayManager),
            new KingSideCastleMoveCommand(replayManager), new QueenSideCastleMoveCommand(replayManager)*/) { }
    }
}
