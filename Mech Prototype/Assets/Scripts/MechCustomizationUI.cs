using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MechCustomizationUI : MonoBehaviour {

	public static GameObject thisObject;
	public GameObject mechCustomizationPannel;
	public bool firstOneDone = false;
	public GameObject playerOne;
	public GameObject playerTwo;
	public Text leftArmText;
	public Text rightArmText;
	public Text mechBodyText;
	public Text mechLegsText;

	public GameObject leftArmP1;
	public GameObject rightArmP1;
	public GameObject mechBodyP1;
	public GameObject mechLegsP1;

	public GameObject leftArmP2;
	public GameObject rightArmP2;
	public GameObject mechBodyP2;
	public GameObject mechLegsP2;

	public List<GameObject> leftArms = new List<GameObject>();
	public List<GameObject> rightArms = new List<GameObject>();
	public List<GameObject> bodys = new List<GameObject>();
	public List<GameObject> legs = new List<GameObject>();

	void Start () 
	{
		if(thisObject == null)
		{
			thisObject = this.gameObject;
		}
		else if(thisObject != this.gameObject)
		{
			Destroy(this.gameObject);
		}

		DontDestroyOnLoad(this.gameObject);

		leftArmP1 = leftArms[0];
		rightArmP1 = rightArms[0];
		mechBodyP1 = bodys[0];
		mechLegsP1 = legs[0];
		leftArmP2 = leftArms[0];
		rightArmP2 = rightArms[0];
		mechBodyP2 = bodys[0];
		mechLegsP2 = legs[0];
		leftArmText.text = leftArmP1.name;
		rightArmText.text = rightArmP1.name;
		mechBodyText.text = mechBodyP1.name;
		mechLegsText.text = mechLegsP1.name;
	}
	
	void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

	void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

	public void LeftArm(int i)
	{
		int e = 0;
		if(i == 0)
		{
			if(e != leftArms.Count - 1)
			{
				e += 1;
				leftArmText.text = leftArms[e].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[e];
				}
				else
				{
					leftArmP2 = leftArms[e];
				}
			}
			else
			{
				e = 0;
				leftArmText.text = leftArms[e].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[e];
				}
				else
				{
					leftArmP2 = leftArms[e];
				}
			}
		}

		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				leftArmText.text = leftArms[e].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[e];
				}
				else
				{
					leftArmP2 = leftArms[e];
				}
			}
			else
			{
				e = leftArms.Count - 1;
				leftArmText.text = leftArms[e].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[e];
				}
				else
				{
					leftArmP2 = leftArms[e];
				}
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
				rightArmText.text = rightArms[e].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[e];
				}
				else
				{
					rightArmP2 = rightArms[e];
				}
			}
			else
			{
				e = 0;
				rightArmText.text = rightArms[e].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[e];
				}
				else
				{
					rightArmP2 = rightArms[e];
				}
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				rightArmText.text = rightArms[e].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[e];
				}
				else
				{
					rightArmP2 = rightArms[e];
				}
			}
			else
			{
				e = rightArms.Count - 1;
				rightArmText.text = rightArms[e].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[e];
				}
				else
				{
					rightArmP2 = rightArms[e];
				}
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
				mechBodyText.text = bodys[e].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[e];
				}
				else
				{
					mechBodyP2 = bodys[e];
				}
			}
			else
			{
				e = 0;
				mechBodyText.text = bodys[e].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[e];
				}
				else
				{
					mechBodyP2 = bodys[e];
				}
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechBodyText.text = bodys[e].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[e];
				}
				else
				{
					mechBodyP2 = bodys[e];
				}
			}
			else
			{
				e = bodys.Count - 1;
				mechBodyText.text = bodys[e].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[e];
				}
				else
				{
					mechBodyP2 = bodys[e];
				}
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
				mechLegsText.text = legs[e].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[e];
				}
				else
				{
					mechLegsP2 = legs[e];
				}
			}
			else
			{
				e = 0;
				mechLegsText.text = legs[e].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[e];
				}
				else
				{
					mechLegsP2 = legs[e];
				}
			}
		}
		else if(i == 1)
		{
			if(e != 0)
			{
				e -= 1;
				mechLegsText.text = legs[e].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[e];
				}
				else
				{
					mechLegsP2 = legs[e];
				}
			}
			else
			{
				e = bodys.Count - 1;
				mechLegsText.text = legs[e].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[e];
				}
				else
				{
					mechLegsP2 = legs[e];
				}
			}
		}
	}

	public void EnterCurrentSetup()
	{
		if(firstOneDone == true)
		{
			SceneManager.LoadScene(1);
		}
		else
		{
			firstOneDone = true;
		}
	}

	public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		print("ok");
		if (scene.buildIndex == 1)
		{
			print("roger");
			GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
			if(players[0].GetComponent<Player>().playerNumber == 1)
			{
				playerOne = players[0];
				playerTwo = players[1];
			}
			else
			{
				playerOne = players[1];
				playerTwo = players[0];
			}

			playerTwo.transform.GetChild(0).GetComponent<Legholder>().legsPrefab = mechLegsP2;
			playerTwo.transform.GetChild(2).GetComponent<BodyHolder>().bodyPrefab = mechBodyP2;
			playerTwo.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Weaponholder>().weaponObject = leftArmP2;
			playerTwo.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Weaponholder>().weaponObject = rightArmP2;
			playerOne.transform.GetChild(0).GetComponent<Legholder>().legsPrefab = mechLegsP1;
			playerOne.transform.GetChild(2).GetComponent<BodyHolder>().bodyPrefab = mechBodyP1;
			playerOne.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Weaponholder>().weaponObject = leftArmP1;
			playerOne.transform.GetChild(2).GetChild(0).GetChild(1).GetComponent<Weaponholder>().weaponObject = rightArmP1;
		}
	}
}
