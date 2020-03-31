using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed = 0.1f;
    public void FixedUpdate()
    {

        //Flechas
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }

        //Letras
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -4, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(4, 0, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 4, 0), Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-4, 0, 0), Space.World);
        }

    }
}
