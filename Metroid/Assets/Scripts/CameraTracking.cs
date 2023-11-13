using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Arroyo, Jordan
//11/12/2023
//Handle the camera following the player

public class CameraTracking : MonoBehaviour
{

    public GameObject target;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //transform position of the camera - transform position of the target
        offset = transform.position - target.transform.position;


    }

    // Update is called once per frame
    void LateUpdate()
    {

        //as the target/player moves we add offset to this object
        transform.position = target.transform.position + offset;
    }
}
