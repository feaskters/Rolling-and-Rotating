using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainController : MonoBehaviour
{
    // // Start is called before the first frame update
    // public Button left;
    // public Button right;
    public GameObject gameContainer;
    bool isLeft;
    bool isRight;
    public float rotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            gameContainer.transform.Rotate(0,0,rotateSpeed * Time.deltaTime);
        }
        if (isRight)
        {
            gameContainer.transform.Rotate(0,0,- rotateSpeed * Time.deltaTime);
        }
    }

    public void leftDown(){
        AudioController.instance.buttonPlay();
        isLeft = true;
    }
    public void leftUp(){
        isLeft = false;
    }
    public void rightDown(){
        AudioController.instance.buttonPlay();
        isRight = true;
    }
    public void rightUp(){
        isRight = false;
    }
    
}
