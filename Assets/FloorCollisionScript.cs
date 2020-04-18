using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ball.transform.position = new Vector3(-1.78f, 1.99f, -3.24f);
    }
}
