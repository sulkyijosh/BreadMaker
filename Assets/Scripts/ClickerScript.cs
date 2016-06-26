using UnityEngine;
using System.Collections;

public class ClickerScript : MonoBehaviour 
{
	public BreadSelectionScript BSS;
	int clickedNumber;
	int neededClicks;
	int breadCount;
	MainScript MS;

	void Awake()
	{
		MS = GameObject.Find("Main Camera").GetComponent<MainScript>();

		clickedNumber = 0;

		if(UpgradeClick.clickLevel == 0)
		{
			neededClicks = 4;
			breadCount = 1;
		}
		else if(UpgradeClick.clickLevel == 1)
		{
			neededClicks = 3;
			breadCount = 1;
		}
		else if(UpgradeClick.clickLevel == 2)
		{
			neededClicks = 2;
			breadCount = 1;
		}
		else if(UpgradeClick.clickLevel == 3)
		{
			neededClicks = 1;
			breadCount = 1;
		}
		else if (UpgradeClick.clickLevel == 4)
		{
			neededClicks = 0;
			breadCount = 2;
		}
		else if (UpgradeClick.clickLevel == 5)
		{
			neededClicks = 0;
			breadCount = 4;
		}
		else if (UpgradeClick.clickLevel == 6)
		{
			neededClicks = 0;
			breadCount = 6;
		}
		else if (UpgradeClick.clickLevel == 7)
		{
			neededClicks = 0;
			breadCount = 8;
		}
		else if (UpgradeClick.clickLevel == 8)
		{
			neededClicks = 0;
			breadCount = 10;
		}
		else if (UpgradeClick.clickLevel == 9)
		{
			neededClicks = 0;
			breadCount = 15;
		}
		else if (UpgradeClick.clickLevel >= 10)
		{
			neededClicks = 0;
			breadCount = 20;
		}

	}

	public void clickCount()
	{
		if(clickedNumber < neededClicks)
		{
			clickedNumber+=1;
		}
		else if(clickedNumber >= neededClicks)
		{
			breadBaked ();
		}
	}
	public void breadBaked()
	{

		if (BSS.BT == breadType.cookies && MainScript.money >= MS.cookieCost * breadCount) {
			MainScript.money -= MS.cookieCost * breadCount;
			MainScript.cookieCount += breadCount;
		} else if (BSS.BT  == breadType.muffins && MainScript.money >= MS.muffinCost * breadCount) {
			MainScript.money -= MS.muffinCost * breadCount;
			MainScript.muffinCount += breadCount;
		} else if (BSS.BT  == breadType.baguettes && MainScript.money >= MS.baguetteCost * breadCount) {
			MainScript.money -= MS.baguetteCost * breadCount;
			MainScript.baguetteCount += breadCount;
		} else if (BSS.BT  == breadType.angelCake && MainScript.money >= MS.angelCakeCost * breadCount) {
			MainScript.money -= MS.angelCakeCost * breadCount;
			MainScript.angelCakeCount += breadCount;
		} else if (BSS.BT  == breadType.cornBread && MainScript.money >= MS.cornBreadCost * breadCount) {
			MainScript.money -= MS.cornBreadCost * breadCount;
			MainScript.cornBreadCount += breadCount;
		} else if (BSS.BT  == breadType.bagels && MainScript.money >= MS.bagelCost * breadCount) {
			MainScript.money -= MS.bagelCost * breadCount;
			MainScript.bagelCount += breadCount;
		} else if (BSS.BT  == breadType.applePies && MainScript.money >= MS.applePieCost * breadCount) {
			MainScript.money -= MS.applePieCost * breadCount;
			MainScript.applePieCount += breadCount;
		} else if (BSS.BT  == breadType.cinaRolls && MainScript.money >= MS.cinaRollCost * breadCount) {
			MainScript.money -= MS.cinaRollCost * breadCount;
			MainScript.cinaRollCount += breadCount;
		}

		clickedNumber = 0;
	}
}
