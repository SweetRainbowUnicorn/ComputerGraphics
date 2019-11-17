using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class FoodCreation : MonoBehaviour
{
    public float fieldWidth = 8.8f;
    public float fieldLength = 8.8f;
    public GameObject foodPrefab;

    public GameObject currentFood;

    public Vector3 currentPosition;

    void AddNewFood()
    {
        RandomPosition();
        currentFood = Instantiate(foodPrefab, currentPosition, Quaternion.identity);
    }

    void RandomPosition()
    {
        currentPosition = new Vector3(Random.Range
            (fieldWidth*-1, fieldWidth),0.2f,Random.Range(fieldLength*-1, fieldLength));
    }

    private void Update()
    {
        if (!currentFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
