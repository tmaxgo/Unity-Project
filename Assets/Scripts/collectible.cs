using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class collectible : MonoBehaviour
{   
    int CoinScore;
    public UnityEvent collectedFXEvent;

    void Awake()
    {
    
        CoinScore = GameObject.FindWithTag("Player").GetComponent<collector>().Score;
    } 
    private void OnCollisionEnter(Collision collision)
    {       
        OnCollect();
        Debug.Log(GameObject.FindWithTag("Player").GetComponent<collector>().Score);

    }

    private void OnCollect()
    {
        Destroy(gameObject);
        GameObject.FindWithTag("Player").GetComponent<collector>().Score = GameObject.FindWithTag("Player").GetComponent<collector>().Score + 1;
        
        collectedFXEvent.Invoke();
    }
    
}
