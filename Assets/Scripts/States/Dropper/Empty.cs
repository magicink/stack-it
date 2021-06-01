using GameBoard;
using PyxlMedia.States;
using PyxlMedia.States.Controllers;
using UnityEngine;

namespace States.Dropper
{
    public class Empty : State
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
            var addedHeight = dropper.drops > 0 ? 0.3f : 0f;
            transform.position = new Vector3(0, transform.position.y + addedHeight, 0);
            mover.SetDirection();
            mover.SetDestination();

            dropper.GetBlock();
        }

        public override void Update(IStateController controller)
        {
            var dropper = Get<DropperController>(controller);
            if (!dropper) return;
            
            if (dropper.CurrentBlock)
            {
                dropper.SetState(DropperStates.Active);
            }
        }
    }
}