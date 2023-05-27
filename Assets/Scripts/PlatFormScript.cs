using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatFormScript : MonoBehaviour
{
    public int Scene;
    public int NextScene;
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
        SceneManager.LoadScene(NextScene);
        //SceneManager.LoadScene(1);
        
        if(collision.gameObject.CompareTag("Respawn"))
        SceneManager.LoadScene(Scene);
        
    }
}
