using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public SideToSideEnemy regEnemy;

    public float speed;

    public bool goingRight;

    public int dmgHP = 1;

    public void OnTriggerEnter(Collider other)
    {
        
        Destroy(this.gameObject);
        
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnDelay());
    }

    // Update is called once per frame
    void Update()
    {
        if (goingRight)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
     

    }

   private void ObjectDies()
    {
        if (regEnemy.enemyHP == 0)
        {
            Destroy(gameObject);
        }
    }

    

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }


}
