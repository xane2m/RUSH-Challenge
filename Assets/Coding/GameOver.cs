using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManager namespace
public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(1); // Load the scene with the index of 1 (the second scene in the build settings)
        }
    }
    void Update()
    {
    }
}