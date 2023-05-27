using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float keyInput;
    public float newkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*4 , ForceMode.VelocityChange);
        }

        keyInput = Input.GetAxis("Horizontal");
        //newkey = Input.GetAxis("Vertical");
        GetComponent<Rigidbody>().velocity= new Vector3(keyInput , GetComponent<Rigidbody>().velocity.y ,0);
       // GetComponent<Rigidbody>().velocity= new Vector3(0 ,newkey ,0);

    }
}
