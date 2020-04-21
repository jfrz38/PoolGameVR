using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed = 0.1f;

    /*System.Single inputX;
    System.Single inputZ;
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");

        if (inputX != 0)
            rotate();
        if (inputZ != 0)
            move();
    }

    void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime, 0f));
    }

    void move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime;
    }*/
    public void FixedUpdate()
    {

        //Flechas = movimiento
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

        //Letras = rotacion
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -4, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(4, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 4, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-4, 0, 0));
        }

    }
}
