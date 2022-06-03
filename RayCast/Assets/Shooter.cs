using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooter : MonoBehaviour
{
    public GameObject bala;
    public Transform Shotposition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1")) 
        {
            Instantiate(bala, Shotposition.position, transform.rotation);
        }
    }
}
