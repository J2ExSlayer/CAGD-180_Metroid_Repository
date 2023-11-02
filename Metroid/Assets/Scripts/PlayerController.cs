using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

//Natalie Gallegos
//10/26/2023
//this script is for the player movement 

public class Player : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody rigidbodyRef;

    public float jumpForce = 10f;

    public int health = 99;

    public bool facingRight = true;

    private bool canTakeDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        //this gets the rigidbody component off of the this object and stores a reference to it
        rigidbodyRef = GetComponent<Rigidbody>(); 
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


    private void damageHP()
    {
       
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

       // rigidbodyRef.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);


    }

    /*
    private void Respawn()
    {
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




}
