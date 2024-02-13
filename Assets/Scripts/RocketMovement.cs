using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float rotation;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offset;
        transform.Rotate(0, 0, rotation * Time.deltaTime);
    }
}
