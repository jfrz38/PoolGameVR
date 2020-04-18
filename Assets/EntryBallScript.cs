using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryBallScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball)
        {
            if (ball.tipo == TipoBola.Blanca)
            {
                ball.transform.position = new Vector3(-1.78f, 1.99f, -3.24f);
                return;
            }
            Global.InsertBall(collision.gameObject.GetComponent<Ball>());
            Destroy(collision.gameObject);
        }
    }
}
