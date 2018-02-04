using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MechCustomizationUI : MonoBehaviour {

	public Text leftArmText;
	public Text rightArmText;
	public Text mechBodyText;
	public Text mechLegsText;

	public GameObject leftArm;
	public GameObject rightArm;
	public GameObject mechBody;
	public GameObject mechLegs;

	public List<GameObject> arms = new List<GameObject>();
	public List<GameObject> bodys = new List<GameObject>();
	public List<GameObject> legs = new List<GameObject>();

	void Start () 
	{
		Time.timeScale = 0;
	}
	
	void Update () {
		
	}

	public void LeftArm(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != arms.Count - 1)
			{
				e += 1;
				leftArm = arms[e];
			}
			else
			{
				e = 0;
				leftArm = arms[e];
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				leftArm = arms[e];
			}
			else
			{
				e = arms.Count - 1;
				leftArm = arms[e];
			}
		}
	}
	public void RightArm(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != arms.Count - 1)
			{
				e += 1;
				rightArm = arms[e];
			}
			else
			{
				e = 0;
				rightArm = arms[e];
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				rightArm = arms[e];
			}
			else
			{
				e = arms.Count - 1;
				rightArm = arms[e];
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
			}
			else
			{
				e = 0;
				mechBody = bodys[e];
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechBody = bodys[e];
			}
			else
			{
				e = bodys.Count - 1;
				mechBody = bodys[e];
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
			}
			else
			{
				e = 0;
				mechLegs = legs[e];
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechLegs = legs[e];
			}
			else
			{
				e = bodys.Count - 1;
				mechLegs = legs[e];
			}
		}
	}

	public void EnterCurrentSetup()
	{
		
	}
}
