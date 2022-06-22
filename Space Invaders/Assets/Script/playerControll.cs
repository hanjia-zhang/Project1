using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public Rigidbody2D player;

    private float xRange = 4.2f;
    private float yRange = 4.2f;

    public float nextFire = 0.25f;
    public float currentTime = 0.0f;

    public Animator animator;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {

       if(transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }

        currentTime += Time.deltaTime;

        //Launch a projectile from the player
        if(Input.GetKeyDown(KeyCode.Space) && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }

        animator.SetFloat("Speed", Input.GetAxis("Horizontal") * moveSpeed);
        animator.SetFloat("Speed2", Input.GetAxis("Horizontal") * moveSpeed);

    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;

        
    }
    
    
}
