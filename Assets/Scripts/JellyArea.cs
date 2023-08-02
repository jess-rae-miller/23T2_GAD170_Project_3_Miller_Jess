using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JellyArea : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;

    private void Start()
    {
        textBox.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Entered the jelly.");

       // GetComponent<Renderer>().material.color = Color.red;

        //restart the scene
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.Getactivescene(0).buildindex);
        textBox.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("Exited the jelly.");

        // GetComponent<Renderer>().material.color = Random.ColorHSV();

        textBox.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("In the jelly.");
    }
}
