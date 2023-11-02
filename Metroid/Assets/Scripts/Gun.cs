using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bulletPrefab;

    public float spawnrate = 1f;

    public bool shootRight = false;
    
    public bool facingRight = true;

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

        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    private void ShootBullet()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, transform.rotation);
        
        if (facingRight == true)
        {
            bulletInstance.GetComponent<Bullet>().goingRight = shootRight;

        }
        else
        {
            bulletInstance.GetComponent<Bullet>().goingRight = false;
        }
        
        
    }


}
