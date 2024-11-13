using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;
    

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag != "Player")
            return;

        String activeScene = SceneManager.GetActiveScene().name;
        Debug.Log($"Completed {activeScene}");

        completeLevelUI.SetActive(true);
    }

}
