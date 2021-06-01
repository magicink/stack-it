using GameBoard;
using PyxlMedia.States;
using PyxlMedia.States.Controllers;

namespace States.Dropper
{
    public class Active : State
    {
        public override void Enter(IStateController controller)
        {
            var mover = Get<DropperMovementController>(controller);
            if (!mover) return;
            mover.Move = true;
        }
    }
}