using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScript : MonoBehaviour
{
    private GameObject _HealthObject;
    // Start is called before the first frame update
    int Health_Level ;

    void Start()
    {
         _HealthObject = GameObject.FindWithTag("Health");
         Health_Level = GameObject.FindWithTag("Player").GetComponent<collector>().Health;
    }

    void Update()
    {
        //Debug.Log(_HealthObject);
        //Debug.Log(Health_Level);
       _HealthObject.GetComponent<Text>().text = "Health: " + GameObject.FindWithTag("Player").GetComponent<collector>().Health + " / 10";
    } 

   
}
