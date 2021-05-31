using System;
using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Managers
{
    public class InputManager : MonoBehaviour
    {
        public static event Action Touched = delegate {  };
        
        private TouchControls _touchControls;

        private void Awake()
        {
            _touchControls = new TouchControls();
        }

        private void OnDisable()
        {
            _touchControls.Disable();
        }

        private void OnEnable()
        {
            _touchControls.Enable();
        }

        private void Start()
        {
            _touchControls.TouchMap.TouchPress.started += StartTouch;
        }

        private static void StartTouch(InputAction.CallbackContext ctx)
        {
            Touched();
        }
    }
}
