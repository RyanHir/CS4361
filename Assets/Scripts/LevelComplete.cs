using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(buildIndex + 1);
    }
}
