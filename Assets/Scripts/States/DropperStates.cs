using States.Dropper;

namespace States
{
    public static class DropperStates
    {
        public static readonly Active Active = PyxlMedia.States.Factories.StateFactory<Active>.Instance;
        public static readonly Empty Empty = PyxlMedia.States.Factories.StateFactory<Empty>.Instance;
    }
}