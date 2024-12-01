using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isRunning = true;
    public float restartDelay = 1f;
    public Text levelTag;
    public void Start()
    {
        int levelIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log($"abc {levelIndex}");
        levelTag.text = $"Level {levelIndex}";
    }

    public void EndGame()
    {
        if (isRunning == false)
            return;
        isRunning = false;

        Debug.Log("Game Ended");
        Invoke("Restart", restartDelay);
        Restart();
    }

    private void Restart()
    {
        Debug.Log("Game Restarting");
        String activeScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeScene);

    }
}
