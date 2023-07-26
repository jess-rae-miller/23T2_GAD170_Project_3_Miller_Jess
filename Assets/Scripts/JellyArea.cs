using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered the jelly lol");

        GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited the jelly lol");

        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("In the jelly lol");
    }
}
