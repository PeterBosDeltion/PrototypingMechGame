using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [Header("Basic Variables")]
    public int playerNumber;
    public float moveSpeed;
    public float rotateSpeed;
    public float rotationClampMax;
    public float rotationClampMin;
    public float jumpForce;
    public float jumpCoolDown;
    public bool canJump;

    [Header("Track Position Variables")]
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
    // Use this for initialization
    void Start () {
        if (!hasDummy)
        {
            dummyClone = Instantiate(dummy, Vector3.zero, Quaternion.identity);
            hasDummy = true;

        }
        canJump = true;
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
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;

                    

                    dummyClone.transform.position = forwardPos;
                }

                Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                lookPos.y = 0;
                Quaternion rotation = Quaternion.LookRotation(lookPos);
                myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);


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
                if (rotY != 0)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }

                Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                lookPos.y = 0;
                Quaternion rotation = Quaternion.LookRotation(lookPos);
                myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);

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
                if (rotY != 0)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }

                Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                lookPos.y = 0;
                Quaternion rotation = Quaternion.LookRotation(lookPos);
                myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);

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
                if (rotY != 0)
                {
                    Vector3 forwardPos = myBody.transform.position + myBody.transform.forward;



                    dummyClone.transform.position = forwardPos;
                }

                Vector3 lookPos = dummyClone.transform.position - myBody.transform.position;
                lookPos.y = 0;
                Quaternion rotation = Quaternion.LookRotation(lookPos);
                myBody.transform.rotation = Quaternion.Slerp(myBody.transform.rotation, rotation, Time.deltaTime * rotateSpeed);


                myBody.transform.Rotate(transform.rotation.x, rotY * rotateSpeed * Time.deltaTime, transform.rotation.z);
                //float rotX = Input.GetAxis("RightJoyVertical"); <---- ASSIGN THIS TO SOMETHING FOR KEYBOARDS
                //armsParent.transform.Rotate(rotX * rotateSpeed * Time.deltaTime, transform.rotation.y, transform.rotation.z);
            }
          

        }
    }

    public void Jump()
    {
        if(playerNumber == 1 && canJump)
        {
            if (Input.GetButtonDown("Abutton") || Input.GetButtonDown("Space") && !usingController)
            {
                rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
                //this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
                StartCoroutine(JumpCooldown());
                canJump = false;
            }
        }
        if (playerNumber == 2 && canJump)
        {
            if (Input.GetButtonDown("AbuttonPtwo") || Input.GetButtonDown("NumEnter") && !usingController)
            {
                rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
                //this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
                StartCoroutine(JumpCooldown());
                canJump = false;
            }
        }
    }

   IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCoolDown);
        canJump = true;
    }
}
