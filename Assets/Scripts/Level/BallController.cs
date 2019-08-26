using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameover;
    public GameObject explotion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "goal")
        {
            AudioController.instance.fightSuccessPlay();
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            gameover.SetActive(true);
            gameover.GetComponent<GameOverController>().success();
            gameover.GetComponent<Animator>().SetTrigger("show");
            
        }else if (other.gameObject.tag == "panel")
        {
            AudioController.instance.enemydeadPlay();
            Instantiate(explotion, transform.position,Quaternion.Euler(0,0,0));
            gameover.SetActive(true);
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            gameover.GetComponent<GameOverController>().fail();
            gameover.GetComponent<Animator>().SetTrigger("show");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "panel")
        {
            AudioController.instance.enemydeadPlay();
            Instantiate(explotion, transform.position,Quaternion.Euler(0,0,0));
            gameover.SetActive(true);
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            gameover.GetComponent<GameOverController>().fail();
            gameover.GetComponent<Animator>().SetTrigger("show");
            Destroy(gameObject);
        }
    }
}
