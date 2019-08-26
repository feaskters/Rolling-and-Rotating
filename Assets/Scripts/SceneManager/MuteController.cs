using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteController : MonoBehaviour
{
    // Start is called before the first frame update
    Image muteButton;
    public Sprite mute;
    public Sprite unmute;
    void Start()
    {
        muteButton = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            muteButton.sprite = unmute;
        }else{
            muteButton.sprite = mute;
        }
    }

    public void muteChange(){
        if (PlayerPrefs.GetInt("mute") == 0)
        {
            PlayerPrefs.SetInt("mute",1);
        }else{
            PlayerPrefs.SetInt("mute",0);
        }
    }
}
