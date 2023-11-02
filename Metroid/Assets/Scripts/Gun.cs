using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;

    public float spawnrate = 1f;

    public bool shootRight = false;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", 0, spawnrate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bulletInstance.GetComponent<Bullet>().goingRight = shootRight;
    }


}
