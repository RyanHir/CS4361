using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isRunning = true;
    public float restartDelay = 1f;

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
