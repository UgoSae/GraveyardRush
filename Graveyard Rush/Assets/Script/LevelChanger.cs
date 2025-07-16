using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    [SerializeField] private string menuSceneName = "MainMenu";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        int current = SceneManager.GetActiveScene().buildIndex;
        int next   = current + 1;

        // Masih ada level berikutnya? → muat level berikutnya
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(next);
        }
        // Kalau tidak (berarti di Level3) → balik ke Main Menu
        else
        {
            SceneManager.LoadScene(menuSceneName);
        }
    }
}