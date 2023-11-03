using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;

    public bool goingRight;
    

    private void OnTriggerEnter(Collider other)
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
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
     

    }

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }


}
