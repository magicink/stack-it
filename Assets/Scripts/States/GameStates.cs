using States.Game;

namespace States
{
    public static class GameStates
    {
        public static readonly Playing Playing = PyxlMedia.States.Factories.StateFactory<Playing>.Instance;
        public static readonly Idle Idle = PyxlMedia.States.Factories.StateFactory<Idle>.Instance;
        public static readonly Demo Demo = PyxlMedia.States.Factories.StateFactory<Demo>.Instance;
    }
}