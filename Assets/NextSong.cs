using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSong : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameObject.Find("Satellite_center").GetComponent<PlayMusic>().NextSong();
    }
}
