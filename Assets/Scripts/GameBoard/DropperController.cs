using System;
using System.Collections.Generic;
using Managers;
using States;
using UnityEngine;

namespace GameBoard
{
    public class DropperController : PyxlMedia.States.Controllers.StateController
    {
        [SerializeField] private List<Block> blocks = new List<Block>();

        public static event Action Drop = delegate {  };

        private Block CurrentBlock { get; set; }

        private void Awake()
        {
            SetState(DropperStates.Empty);
        }

        private void Start()
        {
            InputManager.Touched += OnTouched;
        }

        private void OnTouched()
        {
            if (CurrentBlock)
            {
                CurrentBlock.Drop();
            }
        }

        public void GetBlock()
        {
            if (blocks.Count < 1) return;
            var index = UnityEngine.Random.Range(0, blocks.Count);
            var prefab = blocks[index];
            CurrentBlock = Instantiate(prefab, transform.position, Quaternion.identity, transform);
            if (CurrentBlock)
            {
                SetState(DropperStates.Active);
            }
        }
    }
}
