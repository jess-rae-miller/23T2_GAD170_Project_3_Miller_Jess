using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JellyArea : MonoBehaviour
{
    [SerializeField] private TextMeshPro textBox;
    [SerializeField] private TextMeshPro pressEText;
    [SerializeField] private bool isNextToButton;
    [SerializeField] private GameObject fallingEnemy;
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        textBox.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isNextToButton)
        {
            Debug.Log("You hit the button.");

            Instantiate(fallingEnemy, spawnPoint.position, Random.rotation);
        }
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

    //private void OnTriggerEnter(Collider other)
   // {
        //if (other.CompareTag("Player"))
       // {
           //pressEText.enabled = true;
       // }
   // }
}
