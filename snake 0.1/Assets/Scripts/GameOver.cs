using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text finalScoreText;
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ToggleEndMenu(int score)
    {
        gameObject.SetActive(true);
        finalScoreText.text = score.ToString();
    }
}
