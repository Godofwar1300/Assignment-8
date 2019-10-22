using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * (Christopher Green)
 * (UIManager.cs)
 * (Assigment 8)
 * (This code is responsible for displaying the UI prompt.)
 */
public class UIManager : MonoBehaviour
{
    public GameObject worldSpaceCanvas;
    public static UIManager instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisplayOff()
    {
        yield return new WaitForSeconds(5);
        worldSpaceCanvas.SetActive(false);
    }

    public void DisplayPrompt()
    {
        worldSpaceCanvas.SetActive(true);
        StartCoroutine(DisplayOff());
    }
}
