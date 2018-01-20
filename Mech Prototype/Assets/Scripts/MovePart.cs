using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovePart : MonoBehaviour {
    public float jumpForce;
    public Player player;

    public float jumpCoolDown;
    public bool canJump;

    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void Jump();

    public abstract IEnumerator JumpCooldown();

   
}
