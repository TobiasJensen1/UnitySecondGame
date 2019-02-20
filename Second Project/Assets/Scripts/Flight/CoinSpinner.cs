using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CoinSpinner : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveCoin");
    }

    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }


    IEnumerator MoveCoin()
    {

        while (true)
        {
            int num = Random.Range(1, 6);

            switch (num)
            {
                case 1:
                    if(transform.position.z < 1000)
                    { 
                    transform.DOMoveZ(transform.position.z + 50, 5);
                    break;
                    }
                    else
                    {
                        transform.DOMoveZ(transform.position.z - 50, 5);
                        break;
                    }
                case 2:
                    if (transform.position.z > 60)
                    {
                        transform.DOMoveZ(transform.position.z - 50, 5);
                        break;
                    }
                    else
                    {
                        transform.DOMoveZ(transform.position.z + 50, 5);
                        break;
                    }
                case 3:
                    transform.DOMoveX(transform.position.x + 50, 5);
                    break;
                case 4:
                    transform.DOMoveZ(transform.position.x - 50, 5);
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        yield return new WaitForSeconds(5);
        }
    }
}
