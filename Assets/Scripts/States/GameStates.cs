namespace States
{
    
    public class GameStates
    {
        public class PlayingState : PyxlMedia.States.State {}
        public class IdleState : PyxlMedia.States.State {}
        public class DemoState : PyxlMedia.States.State {}

        public static PlayingState Playing = PyxlMedia.States.Factories.StateFactory<PlayingState>.Instance;
        public static IdleState Idle = PyxlMedia.States.Factories.StateFactory<IdleState>.Instance;
        public static DemoState Demo = PyxlMedia.States.Factories.StateFactory<DemoState>.Instance;
    }
}