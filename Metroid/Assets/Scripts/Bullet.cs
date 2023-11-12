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
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
     

    }

    IEnumerator DespawnDelay()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }


}
