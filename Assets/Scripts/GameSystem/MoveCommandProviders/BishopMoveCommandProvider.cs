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
    [MoveCommandProvider(BishopMoveCommandProvider.Name)]
    public class BishopMoveCommandProvider : AbstractMoveCommandProvider
    {
        public const string Name = "Bishop";

        public BishopMoveCommandProvider(PlayGameState playGameState, ReplayManager replayManager) : base(playGameState/*, new BishopBasicMoveCommand(replayManager)*/) { }
    }
}
