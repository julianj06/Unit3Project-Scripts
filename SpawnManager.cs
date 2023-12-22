using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    private float startDelay = 2;
    private float repeatRate = 2;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }
void SpawnObstacle (){
    Instantiate (obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
}
    // Update is called once per frame
    void Update()
    {
    }
}
