using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    int saveLevel;//用户存档中的关卡
    int btnLevel;//按钮上的数字
    void Start()
    {

        //设置最大关卡
        PlayerPrefs.SetInt("maxLevel",15);

        GetComponentInChildren<Text>().text = gameObject.name;
        btnLevel = int.Parse(gameObject.name);
        saveLevel = PlayerPrefs.GetInt("level") == 0 ? 1 : PlayerPrefs.GetInt("level");

        if (btnLevel > saveLevel)
        {
            GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void levelBtnClick(){
        AudioController.instance.buttonPlay();
        GameObject.Find("SceneManager").GetComponent<SceneManagerScript>().toSpecificScene(btnLevel);
    }
}
