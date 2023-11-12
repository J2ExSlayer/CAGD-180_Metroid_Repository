using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;

    public float spawnrate = 1f;
    public float fireRate;

    public bool shootRight = false;
    public bool facingRight = true;
    public bool justShot = false;
    public bool gunShot = false;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("ShootBullet", 0, spawnrate);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {

            if (facingRight == true)
            {
                
                facingRight = false;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            

            if (facingRight == false)
            {
                
                facingRight = true;
            }
        }


        /*
            if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.W))
            {
                ShootBulletUpDiagonal();
            }
            if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.W))
            {
                ShootBulletUpDiagonal();
            }

            if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.S))
            {
                ShootBulletDownDiagonal();
            }
            if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S) && Input.GetMouseButtonUp(0) && gunShot == false)
            {
                ShootBulletDownDiagonal();
            }
        */
            if (Input.GetMouseButtonUp(0) && gunShot == false)
            {

                ShootBullet();



            }
            
    }

    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bulletInstance.transform.Rotate(new Vector3(0, 0, 45));


        if (facingRight == true)
        {
            bulletInstance.GetComponent<Bullet>().goingRight = shootRight;

        }
        else
        {
            bulletInstance.GetComponent<Bullet>().goingRight = false;
        }
        StartCoroutine(FireRate());
        
    }

    /*

    private void ShootBulletUpDiagonal()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bulletInstance.transform.Rotate(new Vector3(0, 0, 45));


        if (facingRight == true)
        {
            bulletInstance.GetComponent<Bullet>().goingRight = shootRight;

        }
        else
        {
            bulletInstance.GetComponent<Bullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }

    private void ShootBulletDownDiagonal()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bulletInstance.transform.Rotate(new Vector3(0, 0, -45));


        if (facingRight == true)
        {
            bulletInstance.GetComponent<Bullet>().goingRight = shootRight;

        }
        else
        {
            bulletInstance.GetComponent<Bullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }
    */


    IEnumerator FireRate()
    {
        gunShot = true;
        yield return new WaitForSeconds(0.5f);
        gunShot = false;
        
    }

    
    
}
