using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [Header("Basic Variables")]
    public int playerNumber;
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpForce;

    public bool usingController;
    private Rigidbody rb;

    [Header("Modular Parts")]
    public GameObject myBody;
    public GameObject armsParent;
    public GameObject myLeftArm;
    public GameObject myRightArm;
    public GameObject myLegs;
    Vector3 direction;
    Camera myCam;
    // Use this for initialization
    void Start () {
            rb = GetComponent<Rigidbody>();
        myCam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate () {

        Move();
        Jump();
    }

    public void Move()
    {
        if (playerNumber == 1)
        {
            if (usingController)
            {
                float z = Input.GetAxis("LeftJoyVertical");
                float x = Input.GetAxis("LeftJoyHorizontal");
                transform.position += transform.forward * -z * moveSpeed * Time.deltaTime ;
                transform.Rotate(transform.rotation.x, x * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotY = Input.GetAxis("RightJoyHorizontal");
           

                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
            }
            else
            {
                float z = Input.GetAxis("Vertical");
                float x = Input.GetAxis("Horizontal");
                transform.position += transform.forward * z * moveSpeed * Time.deltaTime;
                transform.Rotate(transform.rotation.x, x * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotY = Input.GetAxis("QE");


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
            }

           
        }
        else if (playerNumber == 2)
        {
            if (usingController)
            {
                float z = Input.GetAxis("LeftJoyVerticalPtwo");
                float x = Input.GetAxis("LeftJoyHorizontalPtwo");

                transform.position += transform.forward * -z * moveSpeed * Time.deltaTime;
                transform.Rotate(transform.rotation.x, x * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotY = Input.GetAxis("RightJoyHorizontalPtwo");


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
            }
            else
            {
                float z = Input.GetAxis("VerticalArrows");
                float x = Input.GetAxis("HorizontalArrows");

                transform.position += transform.forward * z * moveSpeed * Time.deltaTime;
                transform.Rotate(transform.rotation.x, x * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotY = Input.GetAxis("79");


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
            }
          

        }
    }

    public void Jump()
    {
        if(playerNumber == 1)
        {
            if (Input.GetButtonDown("Abutton") || Input.GetButtonDown("Space"))
            {
                this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
            }
        }
        else if (playerNumber == 2)
        {
            if (Input.GetButtonDown("AbuttonPtwo") || Input.GetButtonDown("NumEnter"))
            {
                this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
            }
        }
    }

   
}
