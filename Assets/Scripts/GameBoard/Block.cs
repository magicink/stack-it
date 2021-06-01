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
            if (_rigidbody)
            {
                _rigidbody.useGravity = false;
                _rigidbody.isKinematic = true;
            }
            var rotationIndex = Random.Range(0, Rotations.Degrees.Length);
            var rotation = Rotations.Degrees[rotationIndex];
            transform.Rotate(0, rotation, 0);
        }

        public void Drop()
        {
            transform.parent = null;
            _rigidbody.useGravity = true;
            _rigidbody.isKinematic = false;
        }
    }
}
