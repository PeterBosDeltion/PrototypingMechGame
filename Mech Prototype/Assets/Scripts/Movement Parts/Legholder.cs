using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legholder : MonoBehaviour {
    public GameObject legsPrefab;
    public GameObject legsObject;
    private MovePart move;
	// Use this for initialization
	void Start () {
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Setup()
    {
        legsObject = Instantiate(legsPrefab, transform.position, Quaternion.identity);
        legsObject.transform.SetParent(transform);
        legsObject.transform.localRotation = new Quaternion(-90, 0, 0, 0);
        legsObject.transform.localPosition = Vector3.zero;
        move = legsObject.GetComponent<MovePart>();
        move.rb = GetComponentInParent<Rigidbody>();
        move.canJump = true;
        move.player = GetComponentInParent<Player>();

    }
}
