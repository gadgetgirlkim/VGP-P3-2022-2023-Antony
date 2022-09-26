using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float fowardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        //move the vehicale foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput); 
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);   
    }
}
