using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public int timer;
    public Text countdown;
    public Rigidbody rb;
    Vector3 originalPos;


    // Start is called before the first frame update
    void Start()
    {
        originalPos = rb.transform.position;
        StartCoroutine("LoseTime");

    }

    // Update is called once per frame
    void Update()
    {
        
        countdown.text = "" + timer;

        if(timer == 0f)
        {
            SceneManager.LoadScene(0);
        }
    }


    IEnumerator LoseTime()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        print("test");
        if (other.gameObject.CompareTag("Timer"))
        {
            print("collision");
            timer = timer + 10;
            Destroy(other.gameObject);
        }
    }
}
