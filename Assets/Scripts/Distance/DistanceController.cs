using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    [SerializeField] float timer = 0.0f;
    [SerializeField] Text tiempo;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        tiempo.text = "Distancia: " + timer.ToString("f0") + " mts";
    }
}
