using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveforward : MonoBehaviour
{
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        //Move fire projectile
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
