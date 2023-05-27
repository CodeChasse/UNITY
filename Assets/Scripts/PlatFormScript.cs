using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Condy"))
        Debug.Log("Candy");
        if(collision.gameObject.CompareTag("Respawn"))
        Debug.Log("platform");
    }
}
