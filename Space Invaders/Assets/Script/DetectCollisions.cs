using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{
    AudioSource Exp;
    // Start is called before the first frame update
    void Start()
    {
        Exp = GameObject.Find("SoundEffect").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
        else if(collision.gameObject.CompareTag("Boss"))
        {
            BossHealth hitpoints = collision.GetComponent<BossHealth>();
            hitpoints.HitHealth --;
            
            Exp.Play();

            if(hitpoints.HitHealth< 1)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                Debug.Log("You Win");
                SceneManager.LoadScene("WinEnd");
            }
            else
            {
                Destroy(gameObject);
            }
            
        }

    }
}
