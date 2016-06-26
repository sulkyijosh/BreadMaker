using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UpgradeChefLevel : MonoBehaviour 
{
	public static int chefLevel;
	public int chefUpgradePrice;
	public Text chefUpgradePriceText;
	int[] chefUpgradeCost = {1000, 1500, 2000, 3000, 5000, 7000, 10000, 15000, 30000, 60000};

	void Update()
	{
		int nextLevel = chefLevel + 1;
		chefUpgradePrice = chefUpgradeCost[chefLevel];

		if(chefLevel <= 7)
		{
		chefUpgradePriceText.text = "Chef Upg: Lvl " + nextLevel + "\n$" + chefUpgradePrice;
		}
		else if (chefLevel == 8)
		{
			chefUpgradePriceText.text = "Chef Level Max";
		}
	}
		
	public void UpgradeChef()
	{
		if(chefLevel <= 7){
			if(MainScript.money >= chefUpgradePrice)
			{
				MainScript.money -= chefUpgradePrice;
				chefLevel++;
			}
		}
	}
}
