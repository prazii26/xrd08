using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    void OnCollisionEnter(Collision other) // For Collision Detection Default Function
    {
        if (other.gameObject.CompareTag("Player")) // Checking if particular Gameobject is colliding {
        {
            SceneManager.LoadScene(1); //Loading Next Scene
        }
    }
}