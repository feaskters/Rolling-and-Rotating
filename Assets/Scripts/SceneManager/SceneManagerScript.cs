using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backToMain(){
        AudioController.instance.buttonPlay();
        SceneManager.LoadScene("MainScene");
    }

    public void toLevelScene(){
        AudioController.instance.buttonPlay();
        SceneManager.LoadScene("LevelScene");
    }

    public void toSpecificScene(int level){
        SceneManager.LoadScene(level + "Level");
    }
}
