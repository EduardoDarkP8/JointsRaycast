using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teste : MonoBehaviour
{

    public Image img;
    public Transform cam;
 

    void Start()
    {
       

    }

    
    void Update()
    {
       
        Ray raio = new Ray(cam.position, cam.forward);
        RaycastHit raioHit;
        Physics.Raycast(raio, out raioHit);
        if (raioHit.transform == null)
        {

            img.color = Color.white;
            return;
            
        }

        if (raioHit.transform.gameObject.tag == "Alvo")
        {

            img.color = Color.red;

        
        }
        else
        {

           
            img.color = Color.white;
        
        }
    }
}
