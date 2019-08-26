using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutorialOut(){
        AudioController.instance.buttonPlay();
        anim.SetTrigger("Out");
    }
}
