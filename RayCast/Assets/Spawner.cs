using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject alvo;

    // Start is called before the first frame update
    void Start()
    {
        Alvos alv = new Alvos(alvo,gameObject.transform,Random.Range(9,20), Random.Range(2, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
