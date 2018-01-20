using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracks : MovePart {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Jump();
	}

    public override void Jump()
    {
        if (player.playerNumber == 1 && canJump)
        {
            if (Input.GetButtonDown("Abutton") || Input.GetButtonDown("Space") && !player.usingController)
            {
                rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
                //this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
                StartCoroutine(JumpCooldown());
                canJump = false;
            }
        }
        if (player.playerNumber == 2 && canJump)
        {
            if (Input.GetButtonDown("AbuttonPtwo") || Input.GetButtonDown("NumEnter") && !player.usingController)
            {
                rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
                //this.rb.AddForce(Vector3.up * jumpForce * 2 * Time.deltaTime);
                StartCoroutine(JumpCooldown());
                canJump = false;
            }
        }
    }

    public override IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(jumpCoolDown);
        canJump = true;
    }
}
