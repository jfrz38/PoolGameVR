using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControllerScript : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, -0.8f, 0);  //Bajar la altura
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position += offset;
        transform.position = Camera.main.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        //Mover el controlador con keypad
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }

        Debug.DrawLine(transform.position, new Vector3(0, 0, 0), Color.cyan);
    }
}
