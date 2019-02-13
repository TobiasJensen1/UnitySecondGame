using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{
    public Text text;
    public int score;

    void FixedUpdate()
    {
        text.text = "Coins: " + score + "/10";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            
            print("collision");
            Destroy(other.gameObject);
            score++;

        }
    }
}
