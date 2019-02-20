using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class CoinPickup : MonoBehaviour
{
    public Text text;
    public int score;

    void Update()
    {
        text.text = "Coins: " + score + "/10";
        text.transform.DOScale(1, 1);
        if(score == 10)
        {
            text.DOColor(Color.green, 10);
        } else
        {
        text.DOColor(Color.red, 10);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            
            print("collision");
            Destroy(other.gameObject);
            score++;
            text.transform.DOScale(2 , 0);
            text.DOColor(Color.yellow, 0);
            
            

        }
    }
}
