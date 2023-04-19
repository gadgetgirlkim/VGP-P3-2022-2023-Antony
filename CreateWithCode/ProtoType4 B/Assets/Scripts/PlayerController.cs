using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private RigidBody playerRb;
    public float speed = 5.0f


    // Start is called before the first frame update
    void Start()
    {
        playerRb = getComponent<RigidBody>();

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * speed * forwardInput);
    }
}
