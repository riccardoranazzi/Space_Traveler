using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rocket_buttons : MonoBehaviour
{

    public Rigidbody rb;
    public float LateralForce;
    public Button left_pressed;
    public Button right_pressed;

    void FixedUpdate()

    {
   

    if(right_pressed == true)

        {
            rb.AddForce(LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

      if(left_pressed == true)

        {
            rb.AddForce(-LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
