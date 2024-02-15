using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{

    [SerializeField] private Collider scanner;
    [SerializeField] private Rigidbody cube;
    [SerializeField] private Transform cubeTrans;
    [SerializeField] private Transform center;
    [SerializeField] private Collider player;


    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            transform.RotateAround(center.position, Vector3.up, 20f);
            new Vector3(0f, 0f, 0f);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other == player)
        {
            new Vector3(0f, 0f, 0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == scanner)
        {

            transform.RotateAround(center.position, Vector3.up, Random.Range(-35f, 35f)); 
        }
    }
  
}
