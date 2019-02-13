using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    public GameObject Explosion;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Destroyable")
        {
            print("Collision");
            Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);

            GetComponent<AudioSource>().Play();

            Destroy(collision.gameObject);
            Destroy(this.gameObject, 2);
            print("Explosion");
        }
    }
}

