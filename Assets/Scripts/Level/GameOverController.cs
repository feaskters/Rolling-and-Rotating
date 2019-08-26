using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tip;
    public Button restart;
    public Button next;
    public Button back;
    public int thisLevel = 1;
    void Start()
    {
        restart.onClick.AddListener(() => {
        AudioController.instance.buttonPlay();
            SceneManager.LoadScene(thisLevel + "Level");
        });
        if (thisLevel < PlayerPrefs.GetInt("maxLevel"))
        {
            next.onClick.AddListener(() => {
                AudioController.instance.buttonPlay();
                SceneManager.LoadScene((thisLevel+1) + "Level");
            });
        }else
        {
            next.interactable = false;
        }
        back.onClick.AddListener(()=>{
            AudioController.instance.buttonPlay();
            SceneManager.LoadScene("LevelScene");
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fail(){
        tip.text = "fail";
        next.interactable = false;
    }

    public void success(){
        tip.text = "success";
        if (thisLevel < PlayerPrefs.GetInt("maxLevel"))
        {
            next.interactable = true;
        }
        if (thisLevel + 1 > PlayerPrefs.GetInt("level"))
        {
            GameCenterManager.GetInstance().ReportScore("level", thisLevel);
            PlayerPrefs.SetInt("level", thisLevel + 1);
        }
        
    }
}
