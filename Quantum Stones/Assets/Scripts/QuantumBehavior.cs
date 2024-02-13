using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuantumBehavior : MonoBehaviour
{
    [SerializeField] private Transform quantumCube;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        

    }
}
