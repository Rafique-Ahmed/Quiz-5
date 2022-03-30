using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -30;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound){
            // Just deactivate it
            gameObject.SetActive(false);

        }
        else if (transform.position.z < lowerBound){
            Destroy(gameObject);
        }

        if (transform.position.x > topBound){
            // Just deactivate it
            gameObject.SetActive(false);

        }
        else if (transform.position.x < lowerBound){
            Destroy(gameObject);
        }
    }
    //End of Update function
}
