using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin")) 
        {
            score = score + 1;
            scoreText.text = "Score: " + score + " points"; 
        }
    }
}
