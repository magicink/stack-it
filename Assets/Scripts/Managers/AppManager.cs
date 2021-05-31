using System;
using States;

namespace Managers
{
    public class AppManager : PyxlMedia.States.Controllers.StateController
    {
        public static event Action GameStart = delegate {  };
        public static event Action GameEnd = delegate {  };
        public static event Action DemoStart = delegate {  };

        private void OnGameStart()
        {
            SetState(GameStates.Playing);
            GameStart();
        }

        private void OnGameEnd()
        {
            SetState(GameStates.Idle);
            GameEnd();
        }

        private void OnDemoStart()
        {
            SetState(GameStates.Demo);
            DemoStart();
        }

        private void Awake()
        {
            SetState(GameStates.Idle);
        }
    }
}
