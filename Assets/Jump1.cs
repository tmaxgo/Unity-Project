using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    int Jump_Power = 10;
    void Start()
    {
    
    }
     
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.up * Jump_Power, ForceMode.Impulse);
      //GetComponent<Rigidbody>().AddForce(transform.up * thrust);
        }
    }

    
}