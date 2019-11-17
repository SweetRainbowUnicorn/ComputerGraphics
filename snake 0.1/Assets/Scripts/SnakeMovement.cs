using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Serialization;
using UnityEngine.SocialPlatforms.Impl;

public class SnakeMovement : MonoBehaviour
{
    public Vector3 defaultPosition;
    public float speed;
    public float rotationSpeed;
    public TailMovement snakeTail;

    public List<GameObject> tailObjects = new List<GameObject>();
    public float tailDistance;
    public GameObject tailPrefab;

    public int lives = 1;
    public int score;
    public Text livesText;
    public Text scoreText;

    public GameOver deathMenu;
    void Start()
    {
        tailObjects.Add(gameObject);
    }

    void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
        
        transform.Translate(Time.deltaTime * speed * Vector3.forward);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Time.deltaTime*rotationSpeed*Vector3.up);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Time.deltaTime*rotationSpeed*Vector3.down);
        }
        
        DeathMenu();
    }

    public void AddTail()
    {
        score++;
        Vector3 newTailPosition = tailObjects[tailObjects.Count-1].transform.position;
        newTailPosition.z -= tailDistance;
        tailObjects.Add(Instantiate(tailPrefab, newTailPosition, Quaternion.identity));
    }

    public void AddLives()
    {
        lives++;
    }

    public void ReduceLives()
    {
        lives--;
        defaultPosition = new Vector3(0, 0.25f, 0);
        gameObject.transform.position = defaultPosition;
    }

    void DeathMenu()
    {
        if (lives == 0)
        {
           // Application.LoadLevel(1);
           deathMenu.ToggleEndMenu(score);
        }
    }
}
