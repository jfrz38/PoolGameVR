using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMovement : MonoBehaviour
{

    Transform mainCamera;
    //GameObject leftHand;

    //GameObject firstCamera;
    //Camera secondCamera;
    //bool secondCam;
    //Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("TextRayadas").GetComponent<TextMeshPro>();
        mainCamera = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>().transform;
        //var a = GameObject.Find("MaleFreeSimpleMovement1");
        //leftHand = GameObject.Find("basic_rig L Hand");
        //var c = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<Rigidbody>();
        //var d = GameObject.Find("MaleFreeSimpleMovement1").GetComponentsInChildren<Object>();
        gameObject.transform.position = new Vector3(x:mainCamera.position.x,y:0,z:mainCamera.position.z);
        gameObject.transform.rotation = mainCamera.rotation;

        //cameras = Camera.allCameras;

        //secondCam = false;
        //firstCamera = GameObject.Find("OVRCameraRig");//.GetComponent<OVRCameraRig>().leftEyeCamera;//.GetComponent<Camera>();
        //secondCamera = GameObject.Find("Camera").GetComponent<Camera>();//.GetComponent<Camera>();
        //secondCamera.transform.position = firstCamera.transform.position + offset;

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(mainCamera.position.x, 0f, mainCamera.position.z - 0.2f);
        gameObject.transform.rotation = mainCamera.rotation;
        //leftHand.transform.position = 

        
    }

}
