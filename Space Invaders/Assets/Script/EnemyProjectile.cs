using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0, -1) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HIT")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("You Loss");
            SceneManager.LoadScene("LossEnd");
        }

    }

}

