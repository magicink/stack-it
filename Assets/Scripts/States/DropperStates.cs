using GameBoard;
using PyxlMedia.States;
using PyxlMedia.States.Controllers;
using UnityEngine;

namespace States
{
    public static class DropperStates
    {
        public class ActiveState : State { }

        public class EmptyState : State
        {
            public override void Enter(IStateController controller)
            {
                base.Enter(controller);
                var dropper = Get<DropperController>(controller);
                if (dropper) dropper.GetBlock();
            }
        }

        public class IdleState : State
        {
            public override void Enter(IStateController controller)
            {
                base.Enter(controller);
                var mover = Get<DropperMovementController>(controller);
                if (mover) mover.SetDestination();
            }
        }

        public class MovingState: State {}

        public static readonly ActiveState Active = PyxlMedia.States.Factories.StateFactory<ActiveState>.Instance;
        public static readonly EmptyState Empty = PyxlMedia.States.Factories.StateFactory<EmptyState>.Instance;
        public static readonly IdleState Idle = PyxlMedia.States.Factories.StateFactory<IdleState>.Instance;
        public static readonly MovingState Moving = PyxlMedia.States.Factories.StateFactory<MovingState>.Instance;
    }
}