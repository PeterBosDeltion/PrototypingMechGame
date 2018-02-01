﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    [Header("Basic Variables")]
    public int playerNumber;
    public float moveSpeed;
    public float rotateSpeed;
    public float rotationClampMax;
    public float rotationClampMin;
 

    public float hp;

    private Quaternion armsStartRot;

    [Header("Track Position Variables")]
    public bool usingTracking;
    public GameObject dummy;
    private GameObject dummyClone;
    public bool hasDummy;

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

    private Quaternion lookPos;

    public Image leftArmCooler;
    public Image rightArmCooler;
    // Use this for initialization
    void Start () {
        
        armsStartRot = armsParent.transform.localRotation;
        if (!hasDummy && usingTracking)
        {
            dummyClone = Instantiate(dummy, Vector3.zero, Quaternion.identity);
            hasDummy = true;

        }
        rb = GetComponent<Rigidbody>();
        myCam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (playerNumber == 1 && Input.GetButton("RightJoyClick"))
        {
            armsParent.transform.localRotation = armsStartRot;
        }
        else if (playerNumber == 2 && Input.GetButton("RightJoyClickPtwo"))
        {
            armsParent.transform.localRotation = armsStartRot;
        }

        if(hp <= 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }

    void FixedUpdate () {
        Move();

        
    }

    public void Move()
    {
        if (playerNumber == 1)
        {
            if (usingController)
            {
                float z = Input.GetAxis("LeftJoyVertical");
                float x = Input.GetAxis("LeftJoyHorizontal");

                Vector3 movement = new Vector3(x, 0, -z);

                movement *= moveSpeed * Time.deltaTime;
                transform.Translate(movement);

                if(movement != Vector3.zero)
                {
                    myLegs.transform.rotation = Quaternion.LookRotation(movement);
                }
               
                
                //transform.position += transform.forward * -z * moveSpeed * Time.deltaTime ;
                //transform.Rotate(transform.rotation.x, x * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotY = Input.GetAxis("RightJoyHorizontal");
                if(rotY != 0)
                {
                    lookPos = myBody.transform.rotation;
                }
                else if (myBody.transform.rotation != lookPos && rotY ==0)
                {
                    myBody.transform.rotation = lookPos;
                }
                if (rotY != 0 && usingTracking)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;

                    

                    dummyClone.transform.position = forwardPos;
                }

                if (usingTracking)
                {
                    Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                    lookPos.y = 0;
                    Quaternion rotation = Quaternion.LookRotation(lookPos);
                    myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);
                }


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);

                float rotX = Input.GetAxis("RightJoyVertical");
                armsParent.transform.Rotate(rotX * rotateSpeed * Time.deltaTime,transform.rotation.y , transform.rotation.z);
           


            }
            else
            {
                float z = Input.GetAxis("Vertical");
                float x = Input.GetAxis("Horizontal");
                Vector3 movement = new Vector3(x, 0, -z);

                movement *= moveSpeed * Time.deltaTime;
                transform.Translate(movement);

                if (movement != Vector3.zero)
                {
                    myLegs.transform.rotation = Quaternion.LookRotation(movement);
                }

                float rotY = Input.GetAxis("QE");
                if (rotY != 0 && usingTracking)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }

                if (usingTracking)
                {
                    Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                    lookPos.y = 0;
                    Quaternion rotation = Quaternion.LookRotation(lookPos);
                    myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);
                }

                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);

                //float rotX = Input.GetAxis("RightJoyVertical"); ASSIGN THIS TO SOMETHING FOR KEYBOARDS
                //armsParent.transform.Rotate(rotX * rotateSpeed * Time.deltaTime, transform.rotation.y, transform.rotation.z);

            }

           
        }
        if (playerNumber == 2)
        {
            if (usingController)
            {
                float z = Input.GetAxis("LeftJoyVerticalPtwo");
                float x = Input.GetAxis("LeftJoyHorizontalPtwo");

                Vector3 movement = new Vector3(x, 0, -z);

                movement *= moveSpeed * Time.deltaTime;
                transform.Translate(movement);

                if (movement != Vector3.zero)
                {
                    myLegs.transform.rotation = Quaternion.LookRotation(movement);
                }

                float rotY = Input.GetAxis("RightJoyHorizontalPtwo");
                if (rotY != 0 && usingTracking)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }
                if (usingTracking)
                {
                    Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                    lookPos.y = 0;
                    Quaternion rotation = Quaternion.LookRotation(lookPos);
                    myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);
                }

                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
                float rotX = Input.GetAxis("RightJoyVerticalPtwo");
                armsParent.transform.Rotate(rotX * rotateSpeed * Time.deltaTime, transform.rotation.y, transform.rotation.z);
            }
            else
            {
                float z = Input.GetAxis("VerticalArrows");
                float x = Input.GetAxis("HorizontalArrows");

                Vector3 movement = new Vector3(x, 0, -z);

                movement *= moveSpeed * Time.deltaTime;
                transform.Translate(movement);

                if (movement != Vector3.zero)
                {
                    myLegs.transform.rotation = Quaternion.LookRotation(movement);
                }

                float rotY = Input.GetAxis("79");
                if (rotY != 0 && usingTracking)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }

                if (usingTracking)
                {
                    Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                    lookPos.y = 0;
                    Quaternion rotation = Quaternion.LookRotation(lookPos);
                    myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);
                }


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
                //float rotX = Input.GetAxis("RightJoyVertical"); <---- ASSIGN THIS TO SOMETHING FOR KEYBOARDS
                //armsParent.transform.Rotate(rotX * rotateSpeed * Time.deltaTime, transform.rotation.y, transform.rotation.z);
            }
          

        }
    }

   
}
