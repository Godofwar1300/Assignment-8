using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (SpawnManager.cs)
 * (Assigment 8)
 * (This code is responsible for the spawning of the boxes in the scene.)
 */


public class SpawnManager : MonoBehaviour
{
    public GameObject BoxSmallPrefab;
    private int randX;
    private int randY;
    private int randZ;
    public static SpawnManager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        randX = Random.Range(-27, -32);
        randY = Random.Range(0, 10);
        randZ = Random.Range(15, 18);
        Vector3 spawnPos = new Vector3(randX, randY, randZ);
        Instantiate(BoxSmallPrefab, spawnPos, BoxSmallPrefab.transform.rotation);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }

}
