using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement p;
    public RocketMovement r;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
            p.enabled = false;
            r.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
    }
}
