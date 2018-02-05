﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechCustomizationUI : MonoBehaviour {

	public GameObject mechCustomizationPannel;
	public bool firstOneDone = false;
	public GameObject playerOne;
	public GameObject playerTwo;
	public Text leftArmText;
	public Text rightArmText;
	public Text mechBodyText;
	public Text mechLegsText;

	public GameObject leftArm;
	public GameObject rightArm;
	public GameObject mechBody;
	public GameObject mechLegs;

	public List<GameObject> leftArms = new List<GameObject>();
	public List<GameObject> rightArms = new List<GameObject>();
	public List<GameObject> bodys = new List<GameObject>();
	public List<GameObject> legs = new List<GameObject>();

	void Start () 
	{
		leftArm = leftArms[0];
		rightArm = rightArms[0];
		mechBody = bodys[0];
		mechLegs = legs[0];
		leftArmText.text = leftArm.name;
		rightArmText.text = rightArm.name;
		mechBodyText.text = mechBody.name;
		mechLegsText.text = mechLegs.name;
	}
	
	void Update () {
		
	}

	public void LeftArm(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != leftArms.Count - 1)
			{
				e += 1;
				leftArm = leftArms[e];
				leftArmText.text = leftArm.name;
			}
			else
			{
				e = 0;
				leftArm = leftArms[e];
				leftArmText.text = leftArm.name;
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				leftArm = leftArms[e];
				leftArmText.text = leftArm.name;
			}
			else
			{
				e = leftArms.Count - 1;
				leftArm = leftArms[e];
				leftArmText.text = leftArm.name;
			}
		}
	}
	public void RightArm(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != rightArms.Count - 1)
			{
				e += 1;
				rightArm = rightArms[e];
				rightArmText.text = rightArm.name;
			}
			else
			{
				e = 0;
				rightArm = rightArms[e];
				rightArmText.text = rightArm.name;
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				rightArm = rightArms[e];
				rightArmText.text = rightArm.name;
			}
			else
			{
				e = rightArms.Count - 1;
				rightArm = rightArms[e];
				rightArmText.text = rightArm.name;
			}
		}
	}
	public void MechBody(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != bodys.Count - 1)
			{
				e += 1;
				mechBody = bodys[e];
				mechBodyText.text = mechBody.name;
			}
			else
			{
				e = 0;
				mechBody = bodys[e];
				mechBodyText.text = mechBody.name;
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechBody = bodys[e];
				mechBodyText.text = mechBody.name;
			}
			else
			{
				e = bodys.Count - 1;
				mechBody = bodys[e];
				mechBodyText.text = mechBody.name;
			}
		}
	}
	public void MechLegs(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != legs.Count - 1)
			{
				e += 1;
				mechLegs = legs[e];
				mechLegsText.text = mechLegs.name;
			}
			else
			{
				e = 0;
				mechLegs = legs[e];
				mechLegsText.text = mechLegs.name;
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechLegs = legs[e];
				mechLegsText.text = mechLegs.name;
			}
			else
			{
				e = bodys.Count - 1;
				mechLegs = legs[e];
				mechLegsText.text = mechLegs.name;
			}
		}
	}

	public void EnterCurrentSetup()
	{
		if(firstOneDone == true)
		{
			playerTwo.transform.GetChild(0).GetComponent<Legholder>().legsPrefab = mechLegs;
			playerTwo.transform.GetChild(2).GetComponent<BodyHolder>().bodyPrefab = mechBody;
			playerTwo.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Weaponholder>().weaponObject = leftArm;
			playerTwo.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Weaponholder>().weaponObject = rightArm;
		}
		else
		{
			firstOneDone = true;
			playerOne.transform.GetChild(0).GetComponent<Legholder>().legsPrefab = mechLegs;
			playerOne.transform.GetChild(2).GetComponent<BodyHolder>().bodyPrefab = mechBody;
			playerOne.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Weaponholder>().weaponObject = leftArm;
			playerOne.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Weaponholder>().weaponObject = rightArm;
		}
	}
}
