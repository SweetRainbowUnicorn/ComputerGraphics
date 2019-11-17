using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            other.GetComponent<SnakeMovement>().AddLives();
        }

    }
}
