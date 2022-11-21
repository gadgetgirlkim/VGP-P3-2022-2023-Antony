using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePreFab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstaclePreFab, spawnPos, obstaclePreFab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
