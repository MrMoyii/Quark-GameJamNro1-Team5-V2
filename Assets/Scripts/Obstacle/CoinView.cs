using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    [SerializeField] private GameObject adquiredCoin;

    private Animator anim;
    private GameObject coinSound;

    void Start()
    {
        anim = GetComponent<Animator>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {            
            coinSound = Instantiate(adquiredCoin);
            anim.Play("Coin_Adquired");
            Destroy(coinSound, 2); 
        }
    }
}
