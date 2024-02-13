using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameManager gamemanager;

    public void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        {
            gamemanager.CompleteLevel();
        }
    }
}
