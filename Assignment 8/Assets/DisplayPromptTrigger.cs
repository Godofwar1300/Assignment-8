using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (DisplayPromptTrigger.cs)
 * (Assigment 8)
 * (This code is responsible for the actions that happen when the player walks into the trigger.)
 */

public class DisplayPromptTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            UIManager.instance.DisplayPrompt();
            SpawnManager.instance.StopSpawning();
            Debug.Log("You have entered the trigger.");
        }
    }
}
