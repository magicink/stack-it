using PyxlMedia.States.Controllers;
using UnityEngine;

namespace GameBoard
{
    public class Block : StateController
    {
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Drop()
        {
            transform.parent = null;
            _rigidbody.useGravity = true;
        }
    }
}
