using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shot : MonoBehaviour
{
    Rigidbody ctr;
    public float Speed = 100f;
    Vector3 moveShot;
    

    
    // Start is called before the first frame update
    void Start()
    {

        ctr = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        ctr.velocity = transform.forward * Speed;
        
    }
	private void OnTriggerEnter(Collider other)
	
	{
        if (other.gameObject.tag == "Alvo")
        {
            Destroy(gameObject);


        }
        if (other.gameObject.tag != null)
        {
            Destroy(gameObject);


        }
    }
}
