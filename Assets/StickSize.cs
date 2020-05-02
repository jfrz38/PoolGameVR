﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickSize : MonoBehaviour
{    // Update is called once per frame

    //private Camera camera;
    private bool hasDecided;
    GameObject leftHand;

    private void Start()
    {
        leftHand = GameObject.Find("basic_rig L Hand");
        //camera = GameObject.Find("OVRCameraRig").GetComponent<OVRCameraRig>().leftEyeCamera;//Camera.main;//GameObject.Find("OVRCameraRig");//.GetComponent<Camera>();//Camera.main;
        hasDecided = false;
        Global.InstructionsText(TipoTexto.StickSize);
    }
    void Update()
    {
        //var offset = new Vector3(0, -0.5f, 0);  //Bajar a la altura de la cámara
        //var cameraPos = camera.transform.position + offset;
        var cameraPosition = GameObject.Find("OVRRightHandPrefab").transform.position;// + offset;
        Debug.DrawLine(cameraPosition, new Vector3(0, 0, 0), Color.yellow);
        var handPosition = GetHandPosition();
        //leftHand.transform.localPosition = handPosition;

        //Dirección y distancia entre dos objetos
        var heading = cameraPosition - handPosition;
        var distance = heading.magnitude;
        var direction = heading / distance;

        Debug.DrawLine(cameraPosition, direction, Color.black);
        direction *= -1;
        transform.rotation = Quaternion.LookRotation(direction);
        transform.position = cameraPosition;

        if (!hasDecided)
        {
            //Escalar el palo
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x,
                gameObject.transform.localScale.y,
                distance);

            if (Input.GetMouseButtonDown(1))
            {
                hasDecided = true;
                Global.InstructionsText(TipoTexto.MovementInstructions);
            }
        }


    }

    private Vector3 GetHandPosition()
    {
        //Coger la posición de la mano;
        //mientras tanto coger la posición del ratón

        return GetMousePosition();
    }
    private Vector3 GetMousePosition()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            return hit.point;
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }
}
