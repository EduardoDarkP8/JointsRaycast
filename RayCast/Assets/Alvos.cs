using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alvos : MonoBehaviour
{



    // Start is called before the first frame update
    public Alvos(GameObject gm, Transform transform, int times, float distance) 
   {
        
        int i = 1;
        Vector3 x = transform.position;
        while(i < times)
		{
        
            x.x += distance;
        Instantiate(gm, x, Quaternion.identity);
        
        i++;
        }   
   
   }
	


	void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "shot")
        {
            int types = Random.Range(1, 4);
            Debug.Log("Shot");
            Debug.Log(types.ToString());
            switch (types)
            {
                case 1: Destroy(gameObject); ; break;
                case 2: gameObject.transform.localScale += new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4)); break;
                case 3: gameObject.transform.position += new Vector3(Random.Range(-4, 4), Random.Range(1, 4), Random.Range(-4, 4)); break;
            }
        }
    }
}
