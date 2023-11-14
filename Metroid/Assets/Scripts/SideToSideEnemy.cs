using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Natalie Gallegos
//11/07/2023
//This script focuses on the movement of the enemy, going side to side.


public class SideToSideEnemy : MonoBehaviour
{
    public float travelDistanceRight = 0;
    public float travelDistanceLeft = 0;
    public float speed;

    private float startingX;
    private bool movingRight = true;

    

    public int enemyHP = 1;

    // Start is called before the first frame update
    void Start()
    {
        //when the scene starts, it stores the intial X value of this object
        startingX = transform.position.x;
        

    }

    // Update is called once per frame
    void Update()
    {

        if (movingRight)
        {
            //if the object is not farther than the start position + right travel dist, it can move right
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
            //if the object is not farther than the start position + Left travel dist, it can move left
            if (transform.position.x >= startingX + travelDistanceLeft)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            //if the object goes too far left, tell it to move right
            else
            {
                movingRight = true;
            }
        }

    }





    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            DamageEnemyHP(1);
            Debug.Log("enemy has taken damage, -1");
            if(enemyHP == 0)
            {
                Destroy(this.gameObject);
            }
            
        }
    }





    //this indicates the health of the enemy, and depending from the value will subtract it from them
    public void DamageEnemyHP(int value)
    {
        enemyHP -= value;
    }
    
}
