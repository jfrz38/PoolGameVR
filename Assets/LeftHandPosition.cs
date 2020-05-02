using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //var aa = GameObject.Find("basic_rig L Hand");
        //var bb = aa.GetComponent<Rigidbody>();
        //var cc = GameObject.Find("MaleFreeSimpleMovement1");
        //var dd = cc.GetComponent<Rigidbody>();
        //dd.MovePosition(Vector3.zero);
        //GameObject.Find go = GetComponent
        //rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        var cc = GameObject.Find("MaleFreeSimpleMovement1");
        var dd = cc.GetComponent<Rigidbody>();
        dd.MovePosition(Vector3.zero);

        Quaternion rotation = gameObject.transform.rotation;
        Vector3 myVector = Vector3.one;
        Vector3 rotateVector = rotation * myVector;
        Debug.DrawLine(gameObject.transform.position, rotateVector, Color.green);
    }
}
