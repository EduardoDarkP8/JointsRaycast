using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    float x , y;
    public Transform Body;
    public float Sense = 120;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X")*Time.deltaTime*Sense;
        y -= Input.GetAxis("Mouse Y") * Sense * Time.deltaTime;
        y = Mathf.Clamp(y, -60f, 60f);

    }
	private void FixedUpdate()
	{
        transform.localRotation = Quaternion.Euler(y,0,0);
        Body.localRotation = Quaternion.Euler(0,x,0);
	}
}
