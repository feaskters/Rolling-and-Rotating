using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance {get;private set;}
    public AudioClip buttonClick;
    public AudioClip enemydead;
    public AudioClip fightSuccess;
    public AudioSource theAs;
    public static bool isHaveClone = false;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        theAs.mute = PlayerPrefs.GetInt("mute") != 0;
        GetComponents<AudioSource>()[0].mute = PlayerPrefs.GetInt("mute") != 0;
        GetComponents<AudioSource>()[1].mute = PlayerPrefs.GetInt("mute") != 0;
    }

    public void enemydeadPlay(){
        theAs.PlayOneShot(enemydead);
    }

    public void buttonPlay(){
        theAs.PlayOneShot(buttonClick);
    }


    public void fightSuccessPlay(){
        theAs.PlayOneShot(fightSuccess);
    }

    public void fightPlay(){
        GetComponents<AudioSource>()[1].Pause();
        GetComponents<AudioSource>()[2].Play();
    }

    public void fightEnd(){
        GetComponents<AudioSource>()[2].Stop();
        GetComponents<AudioSource>()[1].UnPause();
    }

}
