using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleResetController : MonoBehaviour
{
    public Rigidbody rb;
    bool reset = false;
    public Text text;
    Vector3 originalPos;





    // Start is called before the first frame update
    void Start()
    {
        originalPos = rb.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = rb.velocity.magnitude;
        float rotation = rb.transform.rotation.z;

        //print(speed);
        
       
        if ((rotation > 0.1) || (rotation < -0.1))
        {
            if(speed < 0.001)
            {
                reset = true;
            }
        }

        if (reset)
        {
            text.text = "Press \"R\" to Reset";
            if (Input.GetKeyDown(KeyCode.R))
            {
                text.text = "";
                reset = false;
                rb.transform.position = originalPos;
                rb.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
                    
                    


                
            }
        }
        
  
    }
}


/* GameObject canvasObject = GameObject.FindGameObjectWithTag("MainCanvas");
   Transform textTr = canvasObject.transform.Find("ObjectName");
Text text = textTr.GetComponent<Text>();*/