using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantumBehavior : MonoBehaviour
{
    [SerializeField] private Collider quantumCube;

    private void OnTriggerEnter(Collider other)
    {
        if (other == quantumCube)
        {
            Debug.Log("enter");
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other == quantumCube)
        {
            Debug.Log("stay");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == quantumCube)
        {
            Debug.Log("exit");
        }
    }


  
}
