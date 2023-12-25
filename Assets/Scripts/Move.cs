using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject right;
    public GameObject left;
    void Start()
    {
        right.gameObject.SetActive(false);
        left.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tunnel")
        {
            right.gameObject.SetActive(true);
            left.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Tunnel")
        {

            right.gameObject.SetActive(false);
            left.gameObject.SetActive(false);
        }
    }
}
