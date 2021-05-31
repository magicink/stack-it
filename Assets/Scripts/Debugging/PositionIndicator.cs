using UnityEngine;

namespace Debugging
{
    public class PositionIndicator : MonoBehaviour
    {
        [SerializeField] private Color color = Color.magenta;
        [SerializeField] private float size = 1;
        
        private void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawWireSphere(transform.position, size);
        }
    }
}
