using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int count { get; private set; }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Line 10 Hitting Pickup");
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
        }
    }
}
