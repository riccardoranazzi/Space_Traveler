using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotation;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
