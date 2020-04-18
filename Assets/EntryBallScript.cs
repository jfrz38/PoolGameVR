using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryBallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>())
        {
            Global.InsertBall(collision.gameObject.GetComponent<Ball>());
            Destroy(collision.gameObject);
        }
    }
}
