using PyxlMedia.States.Controllers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameBoard
{
    public class DropperMovementController : StateController
    {
        [SerializeField] private float speed;
        [SerializeField] private Vector3 direction = Vector3.left;
        [SerializeField] private float distance = 5.0f;
        [SerializeField] private Vector3 destination = Vector3.zero;
        [SerializeField] private float threshold = 0.15f;

        private readonly Vector3[] _directions = {
            Vector3.left, Vector3.right, Vector3.back, Vector3.forward
        };

        public bool Move { get; set; }

        public void Awake()
        {
            SetDirection();
        }

        private void Update()
        {
            if (!Move) return;
            if (Vector3.Distance(transform.position, destination) <= threshold)
            {
                direction *= -1;
                SetDestination();
            }
            
            transform.position += direction * (speed * Time.deltaTime);
        }

        public void SetDirection()
        {
            speed = Random.Range(4f, 12.5f);
            var index = Random.Range(0, _directions.Length);
            direction = _directions[index];
        }

        public void SetDestination()
        {
            var next = direction * distance;
            destination = new Vector3(next.x, transform.position.y, next.z);
        }
    }
}
