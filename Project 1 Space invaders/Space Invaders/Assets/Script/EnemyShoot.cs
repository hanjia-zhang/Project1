using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileSpawn;

    public float nextFire = 2.0f;
    public float currentTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        //projectileSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyShoot();
    }

    public void enemyShoot()
    {
        currentTime += Time.deltaTime;

        if(currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(projectile, transform.position, projectile.transform.rotation);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}
