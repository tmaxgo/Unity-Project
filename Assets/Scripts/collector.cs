using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector : MonoBehaviour
{
    public int Score = 0;
    public int Success = 10;
    public int Health = 10;


    private void OnCollisionEnter(Collision collision)
    {
        if (Score >= Success)
        {
            Debug.Log("You've collected all the collectables");
            Destroy(gameObject);
        }
    }
    

}
