using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public Rigidbody2D boss;
    public float moveSpeed = 15.0f;
    public bool changeDireaction = false;
    // Start is called before the first frame update
    void Start()
    {
        boss = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveBoss();
    }

    public void moveBoss()
    {
        if(changeDireaction == true)
        {
            boss.velocity = new Vector2(1, 0) * -1 * moveSpeed;
        }
        else if (changeDireaction == false)
        {
            boss.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RightWall")
        {
            Debug.Log("hit right");
            changeDireaction = true;
        }
        if (collision.gameObject.name == "LeftWall")
        {
            Debug.Log("hit left");
            changeDireaction = false;
        }
    }
}
