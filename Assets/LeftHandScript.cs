using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OVRHand;

public class LeftHandScript : MonoBehaviour
{
    public OVRHand hand;
    public Transform customPose;
    //private OVRSkeleton skeleton;

    // Start is called before the first frame update
    void Start()
    {
        hand = GetComponent<OVRHand>();
        //customPose = GameObject.Find("CustomHandLeft").transform;
        //skeleton = GetComponent<OVRSkeleton>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //EJEMPLOS
        /*//Devuelve true o false si el dedo indicado está pellizcando (junto con el pulgar)
        bool isIndexFingerPinching = hand.GetFingerIsPinching(HandFinger.Index);
        //Valores entre 0 y 1:
        //  0: No están tocándose el dedo indicado y FingerThumb
        //  1: Están en contacto los dos dedos
        float ringFingerPinchStrength = hand.GetFingerPinchStrength(HandFinger.Ring);
        //Devuelve Low o High según la seguridad de la posición del dedo
        TrackingConfidence confidence = hand.GetFingerConfidence(HandFinger.Index);*/

        //Integrar poses
        var pointerPose = hand.PointerPose;
        var validPose = hand.IsPointerPoseValid;

        if (ComparePoses(hand.PointerPose, customPose))
        {
            //Posisición de la mano correcta: Poner el palo en esta posición
        }
        
        //Debug
        Debug.DrawLine(transform.position, new Vector3(0, 0, 0),Color.red);

        
    }

    private bool ComparePoses(Transform pointerPose, Transform customPose)
    {
        //Comprobar si la pose es la elegida para el movimiento del billar
        return true;
    }
}
