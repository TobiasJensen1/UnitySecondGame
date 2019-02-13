using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsShooter : MonoBehaviour
{


    public float bulletSpeed = 10;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            fire();  
        }

        
        
    }


    void fire()
    {
        print("bang");
        // Instantiate the projectile at the position and rotation of this transform
        GameObject clone = Instantiate(bullet, transform.position, Quaternion.identity);
        // Add force to the cloned object in the object's forward direction
        clone.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(clone, 10);
        
       
    }

    
    }

