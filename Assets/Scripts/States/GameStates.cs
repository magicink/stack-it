namespace States
{
    
    public static class GameStates
    {
        public class PlayingState : PyxlMedia.States.State {}
        public class IdleState : PyxlMedia.States.State {}
        public class DemoState : PyxlMedia.States.State {}

        public static readonly PlayingState Playing = PyxlMedia.States.Factories.StateFactory<PlayingState>.Instance;
        public static readonly IdleState Idle = PyxlMedia.States.Factories.StateFactory<IdleState>.Instance;
        public static readonly DemoState Demo = PyxlMedia.States.Factories.StateFactory<DemoState>.Instance;
    }
}