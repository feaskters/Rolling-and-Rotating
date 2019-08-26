using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainSceneScript : MonoBehaviour
{
    public Button startBtn;
    public Button aboutBtn;
    public Button closeTip;
    public GameObject tipBoard;
    public GameObject audioManager;
    Animator tipController; //提示面板的动画开关控制
    // Start is called before the first frame update
    void Start()
    {
        GameCenterManager.GetInstance().Start();
        if (GameObject.FindWithTag("audioManager") == null)
        {
            audioManager = Instantiate(audioManager);
            DontDestroyOnLoad(audioManager);
        }
        tipController = tipBoard.GetComponent<Animator>();
        startBtn.onClick.AddListener(startBtnClick);
        aboutBtn.onClick.AddListener(aboutBtnClick);
        closeTip.onClick.AddListener(closeTipClick);
    }

    void startBtnClick(){
        AudioController.instance.buttonPlay();
    }

    void aboutBtnClick(){
        AudioController.instance.buttonPlay();
        tipController.SetInteger("Trigger", 1);
    }

    void closeTipClick(){
        AudioController.instance.buttonPlay();
        tipController.SetInteger("Trigger", -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
