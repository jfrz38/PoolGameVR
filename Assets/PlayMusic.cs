using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    List<AudioSource> songs;
    int currentSong = 0;

    void Start()
    {
        //Empieza con la primera canción
        songs = new List<AudioSource>();
        AudioSource audio1 = GameObject.Find("Song1").GetComponent<AudioSource>();
        AudioSource audio2 = GameObject.Find("Song2").GetComponent<AudioSource>();
        AudioSource audio3 = GameObject.Find("Song3").GetComponent<AudioSource>();
        songs.Add(audio1);
        songs.Add(audio2);
        songs.Add(audio3);

        foreach(AudioSource audio in songs)
        {
            audio.Stop();
        }
        
    }
    void OnMouseDown()
    {
        if (songs[currentSong].isPlaying)
        {
            songs[currentSong].Pause();
        }
        else
        {
            songs[currentSong].Play();
        }
    }

    public void NextSong()
    {
        songs[currentSong].Stop();
        currentSong++;
        currentSong %= 3;
        OnMouseDown();
    }
}
