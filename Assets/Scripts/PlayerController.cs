using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField]
    private GameObject projectilePrefab;
    // Start is called before the first frame update
    
    [SerializeField]
    private float speed = 10.0f;

    private float turnSpeed = 45.0f; 



    public AudioClip shootsound;
    private AudioSource playerAudio; 



    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        // Check for left and right bounds


        // Player movement left to right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerAudio.PlayOneShot(shootsound, 1.0f);
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }



    }
}
