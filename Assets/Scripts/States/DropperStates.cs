using GameBoard;
using PyxlMedia.States;
using PyxlMedia.States.Controllers;
using UnityEngine;

namespace States
{
    public static class DropperStates
    {
        public class ActiveState : State
        {
            public override void Enter(IStateController controller)
            {
                var mover = Get<DropperMovementController>(controller);
                if (!mover) return;
                mover.Move = true;
            }
        }

        public class EmptyState : State
        {
            public override void Enter(IStateController controller)
            {
                base.Enter(controller);

                var dropper = Get<DropperController>(controller);
                if (!dropper) return;

                var mover = Get<DropperMovementController>(controller);
                if (!mover) return;
                mover.Move = false;
                var transform = mover.transform;
                var addedHeight = dropper.drops > 0 ? 0.25f : 0f;
                transform.position = new Vector3(0, transform.position.y + addedHeight, 0);
                mover.SetDirection();
                mover.SetDestination();

                dropper.GetBlock();
            }
        }

        public static readonly ActiveState Active = PyxlMedia.States.Factories.StateFactory<ActiveState>.Instance;
        public static readonly EmptyState Empty = PyxlMedia.States.Factories.StateFactory<EmptyState>.Instance;
    }
}