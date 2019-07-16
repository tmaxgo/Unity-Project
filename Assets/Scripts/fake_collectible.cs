using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class fake_collectible : MonoBehaviour
{   
    //public UnityEvent collectedFXEvent;

    void Awake()
    {
        

        //public int Health_Level;
        //Health_Level = GameObject.FindWithTag("Player").GetComponent<collector>().Health;
    }
    private void OnCollisionEnter(Collision collision)
    {       
        OnCollect();
        Destroy(gameObject);
        Debug.Log(GameObject.FindWithTag("Player").GetComponent<collector>().Health);


    }

    private void OnCollect()
    {
        
       // int Health_Level;
        //Health_Level = GameObject.FindWithTag("Player").GetComponent<collector>().Health;

        Destroy(gameObject);
        GameObject.FindWithTag("Player").GetComponent<collector>().Health = GameObject.FindWithTag("Player").GetComponent<collector>().Health - 1;
    
    }
    
}