using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameBoard
{
    public class Boundary : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
