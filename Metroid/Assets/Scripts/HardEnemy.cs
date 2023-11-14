using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Natalie Gallegos
//11/13/2023
//this script focuses on the Hard Enemy

public class HardEnemy : MonoBehaviour
{
    public int enemyHP = 10;

    public float travelDistanceRight = 0;
    public float travelDistanceLeft = 0;
    public float speed;

    private float startingX;
    private bool movingRight = true;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //checking if the player x position is greater than the harde enemy x position, it means the player is to the right
        if (player.transform.position.x > transform.position.x)
        {
            Debug.Log("player is to the right");
            movingRight = true;
        }
        else
        {
            Debug.Log("player is to the left");
            movingRight = false;
        }

        if (movingRight)
        {
            
            if (transform.position.x <= startingX + travelDistanceRight)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else
            {
                movingRight = false;
            }
        }
        else
        {
            
            if (transform.position.x >= startingX + travelDistanceLeft)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
           
            else
            {
                movingRight = true;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            DamageEnemyHP(1);
            Debug.Log("enemy has taken damage, -1");
            if (enemyHP <= 0)
            {
                Destroy(this.gameObject);
            }

        }
        if (other.gameObject.tag == "Heavy Bullet")
        {
            DamageEnemyHP(3);
            Debug.Log("enemy has taken damage, -3");
            if (enemyHP <= 0)
            {
                Destroy(this.gameObject);
            }

        }
    }




    //this indicates the health of the enemy, HP = 10
    public void DamageEnemyHP(int value)
    {
        enemyHP -= value;
    }



}
