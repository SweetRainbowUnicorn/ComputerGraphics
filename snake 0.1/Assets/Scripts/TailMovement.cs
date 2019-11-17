using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public int tailPartId;
    public float speed;

    public GameObject lastTailPart;
    public Vector3 tailTarget;
    public SnakeMovement mainSnake;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeHead").GetComponent<SnakeMovement>();
        speed = mainSnake.speed+3;
        lastTailPart = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
        tailPartId = mainSnake.tailObjects.IndexOf(gameObject);
    }
    
    void Update()
    {
        tailTarget = lastTailPart.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            if (tailPartId > 2)
            {
              //  Application.LoadLevel(0);
              other.GetComponent<SnakeMovement>().ReduceLives();
            }
        }
    }
}
