using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    private void
OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
SceneManager.LoadScene("Level 2");
SceneManager.LoadScene("Level 3");
SceneManager.LoadScene("MainMenu");
        }
    }
}
