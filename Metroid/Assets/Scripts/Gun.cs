using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject heavyBulletPrefab;

    public float spawnrate = 1f;
    public float fireRate;

    public bool shootRight = false;
    public bool facingRight = true;
    public bool justShot = false;
    public bool gunShot = false;
    public bool bullet = false;
    public bool heavyBullet = false;

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


        
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletUpDiagonal();
            }
            else
            {
                ShootHeavyBulletUpDiagonal();
            }
            
            
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletUpDiagonal();
            }
            else
            {
                ShootHeavyBulletUpDiagonal();
            }
            
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletDownDiagonal();
            }
            else
            {
                ShootHeavyBulletDownDiagonal();
            }
            
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletDownDiagonal();
            }
            else
            {
                ShootHeavyBulletDownDiagonal();
            }
        }
        
        if (Input.GetMouseButtonUp(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBullet();
            }
            else
            {
                ShootHeavyBullet();
            }
            


        }

        if (Input.GetKey(KeyCode.W) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletUp();
            }
            else
            {
                ShootHeavyBulletUp();
            }
            
        }

        if (Input.GetKey(KeyCode.S) && Input.GetMouseButton(0) && gunShot == false)
        {
            if (bullet == false)
            {
                ShootBulletDown();
            }
            else
            {
                ShootHeavyBulletDown();
            }
        }


        
        



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //BulletActive(true);
        }
        if (other.gameObject.tag == "Heavy Bullet")
        {
            //HeavyBulletActive(false);
            
        }    
    }

    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet = true;


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
    private void ShootHeavyBullet()
    {
        GameObject heavyBulletInstance = Instantiate(heavyBulletPrefab, transform.position, transform.rotation);

        


        if (facingRight == true)
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = shootRight;

        }
        else
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }

    private void ShootBulletUp()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);


        bulletInstance.transform.Rotate(new Vector3(0, 0, 90));

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
    private void ShootHeavyBulletUp()
    {
        GameObject heavyBulletInstance = Instantiate(heavyBulletPrefab, transform.position, transform.rotation);


        heavyBulletInstance.transform.Rotate(new Vector3(0, 0, 90));

        if (facingRight == true)
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = shootRight;

        }
        else
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }

    private void ShootBulletDown()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bulletInstance.transform.Rotate(new Vector3(0, 0, -90));


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
    private void ShootHeavyBulletDown()
    {
        GameObject heavyBulletInstance = Instantiate(heavyBulletPrefab, transform.position, transform.rotation);

        heavyBulletInstance.transform.Rotate(new Vector3(0, 0, -90));


        if (facingRight == true)
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = shootRight;

        }
        else
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }



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
    private void ShootHeavyBulletUpDiagonal()
    {
        GameObject heavyBulletInstance = Instantiate(heavyBulletPrefab, transform.position, transform.rotation);

        heavyBulletInstance.transform.Rotate(new Vector3(0, 0, 45));


        if (facingRight == true)
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = shootRight;

        }
        else
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = false;
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
    private void ShootHeavyBulletDownDiagonal()
    {
        GameObject heavyBulletInstance = Instantiate(heavyBulletPrefab, transform.position, transform.rotation);

        heavyBulletInstance.transform.Rotate(new Vector3(0, 0, -45));


        if (facingRight == true)
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = shootRight;

        }
        else
        {
            heavyBulletInstance.GetComponent<HeavyBullet>().goingRight = false;
        }
        StartCoroutine(FireRate());

    }

    private void BulletActive(bool active)
    {
        bullet = true;
    }

    private void HeavyBulletActive(bool active)
    {
        heavyBullet = true;
    }



    IEnumerator FireRate()
    {
        gunShot = true;
        yield return new WaitForSeconds(0.5f);
        gunShot = false;
        
    }

    
    
}
