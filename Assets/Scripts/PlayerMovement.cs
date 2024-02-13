using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce;
    public float LateralForce;
    public float speed;

    public bool move_right;
    public bool move_left;

    void Start()
    {
        move_left = false;
        move_right = false;
    }


    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        MovePlayer();
        /*
        if (Input.GetKey("d"))
        {
            rb.AddForce(LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        */
    }

    private void MovePlayer()
    {
        if (move_left)
        {
            rb.AddForce(-LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (move_right)
        {
            rb.AddForce(LateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else
        {
            rb.AddForce(0 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }

    public void PointerDownLeft()
    {
        move_left = true;
    }

    public void PointerUpLeft()
    {
        move_left = false;
    }

    public void PointerDownRight()
    {
        move_right = true;
    }

    public void PointerUpRight()
    {
        move_right = false;
    }



}