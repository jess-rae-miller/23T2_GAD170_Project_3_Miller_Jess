using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ImpactTester : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch! I have triggered something!");
    }
}
