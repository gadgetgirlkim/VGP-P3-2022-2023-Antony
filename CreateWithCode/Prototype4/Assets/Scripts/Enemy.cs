using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject.Find("player");


    // Start is called before the first frame update
    void Start()
    {
        enemyRb.AddForce(player.transform.position - transform.position).normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
