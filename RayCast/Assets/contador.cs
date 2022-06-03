using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		if (GameObject.FindGameObjectWithTag("Alvo") == null) 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

}
