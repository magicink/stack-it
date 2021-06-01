using System;
using System.Collections.Generic;
using Managers;
using States;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameBoard
{
    [RequireComponent(typeof(Block))]
    public class DropperController : PyxlMedia.States.Controllers.StateController
    {
        [SerializeField] private List<Block> blocks = new List<Block>();
        
        public static event Action NewBlock = delegate {  };

        public int drops;
        private Block _currentBlock;

        public Block CurrentBlock
        {
            get => _currentBlock;
            private set
            {
                if (!value) return;
                _currentBlock = value;
                NewBlock?.Invoke();
            }
        }

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
            if (!CurrentBlock) return;
            CurrentBlock.Drop();
            drops += 1;
            SetState(DropperStates.Empty);
        }

        public void GetBlock()
        {
            if (blocks.Count < 1) return;
            var index = Random.Range(0, blocks.Count);
            var prefab = blocks[index];
            var transformProxy = transform;
            CurrentBlock = Instantiate(prefab, transformProxy.position, Quaternion.identity, transformProxy);
        }
    }
}
