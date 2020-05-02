using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCamera : MonoBehaviour
{
    GameObject firstCamera;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(-4,-4,+4);
        firstCamera = GameObject.Find("OVRCameraRig");
        gameObject.transform.position = firstCamera.transform.position + offset;
        //gameObject.tag = "DisabledCamera";
        //gameObject.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = firstCamera.transform.position + offset;
        gameObject.transform.rotation = firstCamera.transform.rotation;
        
    }
}
