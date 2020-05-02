using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float speed = 0.1f;
    public float moveSpeed = 0.04f;

    private void Start()
    {
        gameObject.tag = "EnabledCamera";
    }
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
            //transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
            transform.position += transform.right * Time.deltaTime * 4;// + new Vector3(speed,0,0);//* rotateSpeed;// * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
            transform.position -= transform.right * Time.deltaTime * 4;//- new Vector3(speed, 0, 0);//* rotateSpeed;// * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
            transform.position -= transform.forward * Time.deltaTime * 4;// * rotateSpeed;// * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
            transform.position += transform.forward * Time.deltaTime * 4;// * rotateSpeed; //* Time.deltaTime;
        }

        //Letras = rotacion
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -4, 0));
            //transform.position -= transform.right * rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(4, 0, 0));
            //transform.position -= transform.forward * rotateSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 4, 0));
            //transform.position += transform.right * rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-4, 0, 0));
            //transform.position += transform.forward * rotateSpeed * Time.deltaTime;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            Camera.main.fieldOfView = Math.Max(Camera.main.fieldOfView -= 1, 80);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            Camera.main.fieldOfView = Math.Min(Camera.main.fieldOfView += 1, 94);
        }
    }
}
