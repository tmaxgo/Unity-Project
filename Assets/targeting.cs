using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targeting : MonoBehaviour
{
    GameObject playerObj;
    // Start is called before the first frame update
    
    void Awake()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        
    }

    void Start()
    { 
        Vector3 playerPosition = playerObj.GetComponent<Transform>().position;
        this.transform.LookAt(playerPosition);  
    }  

    // Update is called once per frame
    void FixedUpdate()
    {  
    this.GetComponent<Rigidbody>().AddForce (this.transform.forward * 100);
    Vector3 playerPosition = playerObj.GetComponent<Transform>().position;
    this.transform.LookAt(playerPosition);   
    } 

}
