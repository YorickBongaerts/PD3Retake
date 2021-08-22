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
    [MoveCommandProvider(PawnMoveCommandProvider.Name)]
    public class PawnMoveCommandProvider : AbstractMoveCommandProvider
    {
        public const string Name = "Pawn";

        public PawnMoveCommandProvider(PlayGameState playGameState, ReplayManager replayManager) : base(playGameState/*, new PawnBasicMoveCommand(replayManager), new PawnFirstMoveCommand(replayManager)*/) {}
    }
}
