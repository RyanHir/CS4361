using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision info)
    {
        // Ignore non obstical collisions
        if (info.collider.tag != "Obstical")
            return;
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }
}
