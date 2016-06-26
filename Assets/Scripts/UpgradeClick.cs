using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UpgradeClick: MonoBehaviour 
{
	public static int clickLevel;
	int clickUpgradePrice;
	public Text clickUpgradePriceText;
	int[] clickUpgradeCost = {1000, 1500, 2000, 3000, 10000, 20000, 40000, 100000, 150000, 300000, 700000, 1500000};

	void Awake()
	{
	}

	void start()
	{

	}

	void Update()
	{
		int nextLevel = clickLevel + 1;
		clickUpgradePrice = clickUpgradeCost[clickLevel];

		if(clickLevel <= 9)
		{
			clickUpgradePriceText.text = "Click Upg: Lvl " + nextLevel + "\n$" + clickUpgradePrice;
		}
		else
		{
			clickUpgradePriceText.text = "Click Level Max";
		}
	}



	public void Upgradeclick()
	{
		if(clickLevel <= 9){
			if(MainScript.money >= clickUpgradePrice)
			{
				MainScript.money -= clickUpgradePrice;
				clickLevel++;
			}
		}
	}
}
