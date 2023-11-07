using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Natalie Gallegos
//11/07/2023
//this script focuses on the Hard Enemy

public class HardEnemy : MonoBehaviour
{
    public int HP = 10;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //this indicates the health of the enemy, HP = 10
    private void enemyHP(int value)
    {
        HP -= value;
    }



}
