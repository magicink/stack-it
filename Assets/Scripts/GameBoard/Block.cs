using PyxlMedia.States.Controllers;
using UnityEngine;

namespace GameBoard
{
    public class Block : StateController
    {
        private Rigidbody _rigidbody;
        private BoxCollider _collider;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _collider = GetComponent<BoxCollider>();
        }

        public void Drop()
        {
            transform.parent = null;
            _collider.isTrigger = false;
            _rigidbody.useGravity = true;
        }
    }
}
