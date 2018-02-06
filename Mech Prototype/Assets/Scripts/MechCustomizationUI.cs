using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MechCustomizationUI : MonoBehaviour {

	public int currentLeftArm;
	public int currentRightArm;
	public int currentMechBody;
	public int currentMechLegs; 

	public static GameObject thisObject;
	public GameObject mechCustomizationPannel;
	public bool firstOneDone = false;
	public GameObject playerOne;
	public GameObject playerTwo;
	public Text leftArmText;
	public Text rightArmText;
	public Text mechBodyText;
	public Text mechLegsText;
	public Text currentPlayer;

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

		currentPlayer.text = "Player 1";
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
		if(i == 0)
		{
			if(currentLeftArm != leftArms.Count - 1)
			{
				currentLeftArm += 1;
				leftArmText.text = leftArms[currentLeftArm].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[currentLeftArm];
				}
				else
				{
					leftArmP2 = leftArms[currentLeftArm];
				}
			}
			else
			{
				currentLeftArm = 0;
				leftArmText.text = leftArms[currentLeftArm].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[currentLeftArm];
				}
				else
				{
					leftArmP2 = leftArms[currentLeftArm];
				}
			}
		}

		else if(i == 1)
		{
			if(currentLeftArm != 0)
			{
				currentLeftArm -= 1;
				leftArmText.text = leftArms[currentLeftArm].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[currentLeftArm];
				}
				else
				{
					leftArmP2 = leftArms[currentLeftArm];
				}
			}
			else
			{
				currentLeftArm = leftArms.Count - 1;
				leftArmText.text = leftArms[currentLeftArm].name;
				if(firstOneDone == false)
				{
					leftArmP1 = leftArms[currentLeftArm];
				}
				else
				{
					leftArmP2 = leftArms[currentLeftArm];
				}
			}
		}
	}
	public void RightArm(int i)
	{
		if(i == 0)
		{
			if(currentRightArm != rightArms.Count - 1)
			{
				currentRightArm += 1;
				rightArmText.text = rightArms[currentRightArm].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[currentRightArm];
				}
				else
				{
					rightArmP2 = rightArms[currentRightArm];
				}
			}
			else
			{
				currentRightArm = 0;
				rightArmText.text = rightArms[currentRightArm].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[currentRightArm];
				}
				else
				{
					rightArmP2 = rightArms[currentRightArm];
				}
			}
		}
		else if(i == 1)
		{
			if(currentRightArm != 0)
			{
				currentRightArm -= 1;
				rightArmText.text = rightArms[currentRightArm].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[currentRightArm];
				}
				else
				{
					rightArmP2 = rightArms[currentRightArm];
				}
			}
			else
			{
				currentRightArm = rightArms.Count - 1;
				rightArmText.text = rightArms[currentRightArm].name;
				if(firstOneDone == false)
				{
					rightArmP1 = rightArms[currentRightArm];
				}
				else
				{
					rightArmP2 = rightArms[currentRightArm];
				}
			}
		}
	}
	public void MechBody(int i)
	{
		if(i == 0)
		{
			if(currentMechBody != bodys.Count - 1)
			{
				currentMechBody += 1;
				mechBodyText.text = bodys[currentMechBody].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[currentMechBody];
				}
				else
				{
					mechBodyP2 = bodys[currentMechBody];
				}
			}
			else
			{
				currentMechBody = 0;
				mechBodyText.text = bodys[currentMechBody].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[currentMechBody];
				}
				else
				{
					mechBodyP2 = bodys[currentMechBody];
				}
			}
		}
		else if(i == 1)
		{
			if(currentMechBody != 0)
			{
				currentMechBody -= 1;
				mechBodyText.text = bodys[currentMechBody].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[currentMechBody];
				}
				else
				{
					mechBodyP2 = bodys[currentMechBody];
				}
			}
			else
			{
				currentMechBody = bodys.Count - 1;
				mechBodyText.text = bodys[currentMechBody].name;
				if(firstOneDone == false)
				{
					mechBodyP1 = bodys[currentMechBody];
				}
				else
				{
					mechBodyP2 = bodys[currentMechBody];
				}
			}
		}
	}
	public void MechLegs(int i)
	{
		if(i == 0)
		{
			if(currentMechLegs != legs.Count - 1)
			{
				currentMechLegs += 1;
				mechLegsText.text = legs[currentMechLegs].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[currentMechLegs];
				}
				else
				{
					mechLegsP2 = legs[currentMechLegs];
				}
			}
			else
			{
				currentMechLegs = 0;
				mechLegsText.text = legs[currentMechLegs].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[currentMechLegs];
				}
				else
				{
					mechLegsP2 = legs[currentMechLegs];
				}
			}
		}
		else if(i == 1)
		{
			if(currentMechLegs != 0)
			{
				currentMechLegs -= 1;
				mechLegsText.text = legs[currentMechLegs].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[currentMechLegs];
				}
				else
				{
					mechLegsP2 = legs[currentMechLegs];
				}
			}
			else
			{
				currentMechLegs = legs.Count - 1;
				mechLegsText.text = legs[currentMechLegs].name;
				if(firstOneDone == false)
				{
					mechLegsP1 = legs[currentMechLegs];
				}
				else
				{
					mechLegsP2 = legs[currentMechLegs];
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
			mechBodyP2 = mechBodyP1;
			mechLegsP2 = mechLegsP1;
			leftArmP2 = leftArmP1;
			rightArmP2 = rightArmP1;
			currentPlayer.text = "Player 2";
		}
	}

	public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if (scene.buildIndex == 1)
		{
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
