using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
    
    CharacterController ctr;
    public float Speed = 10;
    public Vector3 movement;
    float mx = 0;
    float mz = 0;
    float Gravity = -9.81f;
    Vector3 vly;
    public Transform groundCheck;
    public float groundDinstance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float Height = 4f;
    public int points = 0;
    public Material mtr;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ctr = GetComponent<CharacterController>();

    }
    
    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDinstance,groundMask);
		if (isGrounded && vly.y < 0) 
        {
            vly.y = -2f;
        }
        if(isGrounded && Input.GetButton("Jump"))
		{
            vly.y = Mathf.Sqrt(Height * -2f * Gravity);
		}
        mx = Input.GetAxis("Horizontal");
        mz = Input.GetAxis("Vertical");
        movement = transform.right * mx + transform.forward * mz;
        vly.y += Gravity*Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
           
    }
	private void FixedUpdate()
	{
        
        ctr.Move(movement * Speed * Time.deltaTime);
        ctr.Move(vly * Time.deltaTime);

       
    }
}
