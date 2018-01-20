using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponholder : MonoBehaviour {
    public GameObject weaponObject;
    public bool onLeftArm;
    private Weapon weapon;
    private Player player;
	// Use this for initialization
	void Start () {
        player = GetComponentInParent<Player>();
        Setup();
        if (onLeftArm)
        {
            weapon.myCooler = player.leftArmCooler;
            weapon.myCooler.color = weaponObject.GetComponent<Renderer>().material.color;
        }
        else
        {
            weapon.myCooler = player.rightArmCooler;
            weapon.myCooler.color = weaponObject.GetComponent<Renderer>().material.color;
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        float leftOne = Input.GetAxis("LeftTrigger");
        float leftTwo = Input.GetAxis("LeftTriggerPtwo");

        float rightOne = Input.GetAxis("RightTrigger");
        float rightTwo = Input.GetAxis("RightTriggerPtwo");
        if (player.playerNumber == 1 && leftOne > 0 && onLeftArm)
        {
            weapon.Use(transform.position);
        }
        else if (player.playerNumber == 1 && rightOne > 0 && !onLeftArm)
        {
            weapon.Use(transform.position);
        }
        else if (player.playerNumber == 2 && leftTwo > 0 && onLeftArm)
        {
            weapon.Use(transform.position);
        }
        else if (player.playerNumber == 2 && rightTwo > 0 && !onLeftArm)
        {
            weapon.Use(transform.position);
        }
    }

    public void Setup()
    {
        weaponObject = Instantiate(weaponObject, player.armsParent.transform.position, transform.rotation);
        weaponObject.transform.SetParent(transform);
        weaponObject.transform.localRotation = new Quaternion(-90, 0, 0, 0);
        weaponObject.transform.localPosition = Vector3.zero;
        weapon = weaponObject.GetComponent<Weapon>();
    }

  
}
