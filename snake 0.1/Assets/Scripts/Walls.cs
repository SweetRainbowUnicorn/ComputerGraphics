using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
           // Application.LoadLevel(0);
           other.GetComponent<SnakeMovement>().ReduceLives();
        }
    }
}
