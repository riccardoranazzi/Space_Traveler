using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{

    public float amplitude = 1.0f;  // Ampiezza del moto armonico
    public float frequency = 1.0f;  // Frequenza del moto armonico
    public float directionX = 0.0f; // Componente X della direzione
    public float directionY = 0.0f; // Componente Y della direzione
    public float directionZ = 0.0f; // Componente Z della direzione


    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(directionX, directionY, directionZ).normalized;
        float displacement = amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = startPosition + direction * displacement;
    }

}
