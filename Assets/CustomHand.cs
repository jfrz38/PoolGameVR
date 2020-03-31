using OVRTouchSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomHand : MonoBehaviour
{
    public Hand hand;
    public Transform customPose;
    // Start is called before the first frame update
    void Start()
    {
        hand = GetComponent<Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hand.isPosed)
        {
            //
        }
    }
}
