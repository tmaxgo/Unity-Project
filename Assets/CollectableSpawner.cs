using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Coin;
    public GameObject Fake_Coin;



    void Awake()
    {
        int i;
        for (i=1; i<= 10; i++)
        {
        Instantiate(Coin, new Vector3( Random.Range(0, 1000), Random.Range(1, 5), Random.Range(0, 1000)), Quaternion.identity );
        Instantiate(Fake_Coin, new Vector3( Random.Range(0, 1000), Random.Range(1, 5), Random.Range(0, 1000)), Quaternion.identity );
        Instantiate(Fake_Coin, new Vector3( Random.Range(0, 1000), Random.Range(1, 5), Random.Range(0, 1000)), Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
