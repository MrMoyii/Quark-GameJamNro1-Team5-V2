using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    [SerializeField] private float score = 0.01f;
    [SerializeField] private Text scoreText;

    public float scrollFactor;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Distancia: " + score.ToString();
    }

    // Update is called once per frame 
    void Update()
    {
        
    }
}
