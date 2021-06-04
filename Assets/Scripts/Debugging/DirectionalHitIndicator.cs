using UnityEditor;
using UnityEngine;

namespace Debugging
{
    public class DirectionalHitIndicator: MonoBehaviour
    {
        [SerializeField] private Color rayColor = Color.magenta;

        [SerializeField] private Color indicatorColor = Color.red;

        [SerializeField] private float size = 0.25f;

        private void OnDrawGizmos()
        {
            // var ray = new Ray(transform.position, Vector3.down);
            // if (!Physics.Raycast(ray, out var hit)) return;
            // Handles.color = rayColor;
            // Handles.zTest = UnityEngine.Rendering.CompareFunction.LessEqual;
            // var position = transform.position;
            // Handles.DrawLine(position, hit.point);
            // Handles.DrawWireDisc(hit.point, hit.normal, size);
            //
            // Handles.color = indicatorColor;
            // Handles.zTest = UnityEngine.Rendering.CompareFunction.Greater;
            // Handles.DrawLine(position, hit.point);
            // Handles.DrawWireDisc(hit.point, hit.normal, size * 1.25f);
        }
    }
}