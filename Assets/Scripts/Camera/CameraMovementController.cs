using System;
using GameBoard;
using UnityEngine;

namespace Camera
{
    public class CameraMovementController : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;
        private Vector3 _currentPosition;
        private Vector3 _targetPosition;

        private void Awake()
        {
            _currentPosition = transform.position;
            _targetPosition = _currentPosition;
        }

        private void Start()
        {
            DropperController.NewBlock += MoveUp;
        }

        private void Update()
        {
            _currentPosition = transform.position;
            if (Vector3.Distance(_currentPosition, _targetPosition) > 0f)
            {
                transform.position = Vector3.Lerp(_currentPosition, _targetPosition, Time.deltaTime * speed);
            }
        }

        private void MoveUp()
        {
            _targetPosition = new Vector3(_currentPosition.x, _currentPosition.y + 0.25f, _currentPosition.z);
        }
    }
}
