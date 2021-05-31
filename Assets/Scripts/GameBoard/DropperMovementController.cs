using PyxlMedia.States.Controllers;
using States;
using UnityEngine;

namespace GameBoard
{
    public class DropperMovementController : StateController
    {
        [SerializeField] private float speed;
        [SerializeField] private Vector3 direction = Vector3.left;
        [SerializeField] private int distance = 5;
        [SerializeField] private Vector3 destination = Vector3.zero;
        [SerializeField] private float threshold = 0.15f;

        public readonly Vector3[] Directions = {
            Vector3.left, Vector3.right, Vector3.back, Vector3.forward
        };
        
        public Vector3 Direction { get; set; }
        public Vector3 Destination { get; set; }
        public float Threshold { get; }

        private void Awake()
        {
            SetState(DropperStates.Idle);
        }

        private void Update()
        {
            // if (Vector3.Distance(transform.position, destination) <= threshold)
            // {
            //     direction *= -1;
            //     SetDestination();
            // }
            //
            // transform.position += direction * (speed * Time.deltaTime);
        }

        public void SetDestination()
        {
            var position = transform.position;
            position = new Vector3(0, position.y, 0);
            var index = Random.Range(0, Directions.Length);
            direction = Directions[index];
            var next = direction * distance;
            destination = new Vector3(next.x, position.y, next.z);
        }
    }
}
