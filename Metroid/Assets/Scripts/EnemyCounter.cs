using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{

    public int enemiesKilled;

    public bool enemyDied;

    public HardEnemy hardEnemy;
    public SideToSideEnemy enemy;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            hardEnemy.GetComponent<HardEnemy>().enemyHP <= 0;
            enemiesKilled++;
            
        }
    }

    
    
    
    
}
