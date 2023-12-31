using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

//Natalie Gallegos
//11/13/2023
//this script is for the player movement 

public class Player : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rigidbodyRef;

    public float jumpForce = 10f;

    
    public int health;
    public int baseHealth = 99;
    public int maxHealth = 100;

    public bool facingRight = true;

    private bool canTakeDamage = true;

    public bool extraHealth = false;

    private Vector3 startPos;

    public int lives = 3;

    public Gun gun;

    // Start is called before the first frame update
    void Start()
    {
        //this gets the rigidbody component off of the this object and stores a reference to it
        rigidbodyRef = GetComponent<Rigidbody>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //this will be the side to side movements of our player.
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            
            if (facingRight == true)
            {
                transform.Rotate(Vector3.up * 180);
                facingRight = false;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;

            if (facingRight == false)
            {
                transform.Rotate(Vector3.up * 180);
                facingRight = true;
            }
        }


        //this will make the player jump with the key board "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HandleJump();
        }


       


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            DamageHP(15);
            Debug.Log("player has taken damage, -15");
            Respawn();
        }
        if(other.gameObject.tag == "HardEnemy")
        {
            DamageHP(35);
            Debug.Log("player has taken damage, -35");
            Respawn();
        }
        if (other.gameObject.tag == "Portal")
        {
            transform.position = other.gameObject.GetComponent<Portal>().teleportPoint.transform.position;
            startPos = transform.position;
        }
        if(other.gameObject.tag== "Extra Health")
        {
            maxHealth += 100;
            health = maxHealth;
            extraHealth = true;
            Debug.Log("picked up extra health");
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Health Pack")
        {
            HealthPack(40);
            if (extraHealth == true && health > maxHealth)
            {
                
                health = maxHealth;
                Debug.Log("health went over and stopped at maxhealth");
                
            }
            if (extraHealth == false && health > baseHealth)
            {
                health = baseHealth;
                Debug.Log("health went over and stopped at basehealth");
            }
            other.gameObject.SetActive(false);
            Debug.Log("pick up health pack");
            
            
        }

        if (other.gameObject.tag == "Heavy Pickup")
        {

            gun.GetComponent<Gun>().bullet = false;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Jump Pack")
        {
            jumpForce = jumpForce * 2;
            other.gameObject.SetActive(false);
        }

    }


    private void Respawn()
    {
        GetComponent<Transform>().position = startPos;
        StartCoroutine(Blink());

        if (health <= 0)
        {
            lives--;
            transform.position = startPos;
            if (lives == 0)
            {
                Debug.Log("Game Ends");
                SceneManager.LoadScene(2);
            }
            health = baseHealth;
            Debug.Log("Health Reset");
        }
    }

    private void HealthPack(int value)
    {
        health += value;
    }

    
    //this gives out the health of the player, and the value helps take away health from the other enemys
    //and will also help with adding in health from the other items
    private void DamageHP(int value)
    {
        health -= value;

    }

    private void HandleJump()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, Vector3.down, out hit, 1.3f))
        {
            Debug.Log("Player is touching the ground");
            rigidbodyRef.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        else
        {
            Debug.Log("Player is not touching the ground so they can't jump");
        }

       


    }

    /*
    private void Respawn()
    {

        GetComponent<Transform>().position = start_position;
        StartCoroutine(Blink());

        if (//can take damage)
            lives--;
        transform.position = starPos;

        StartCoroutine(SetInvincible());

        if (lives == 0)
        {
            SceneManager.LoadScene();
            Debug.Log("Game Ends");
        }

        IEnumerator SetInvincible()
        {
            canTakeDamage = false;
            yield return new WaitForSeconds(5f);
            canTakeDamage = true;
        }

    }
    */

    public IEnumerator Blink()
    {
        for (int index = 0; index < 30; index++)
        {
            if (index % 2 == 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }






    




}
