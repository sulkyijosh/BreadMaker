using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UpgradeShop : MonoBehaviour 
{
	public static int shopLevel;
	public int shopUpgradePrice;
	public Text shopUpgradePriceText;
	int[] shopUpgradeCost = {2000, 4000, 8000, 15000, 30000, 60000};


	void Update()
	{
		int nextLevel = shopLevel + 1;
		shopUpgradePrice = shopUpgradeCost[shopLevel];

		if(shopLevel <= 4)
		{
			shopUpgradePriceText.text = "Shop Upg: Lvl " + nextLevel + "\n$" + shopUpgradePrice;
		}
		else if (shopLevel == 5)
		{
			shopUpgradePriceText.text = "Shop Level Max";
		}
	}



	public void UpgradeShopLevel()
	{
		if(shopLevel <= 4){
			if(MainScript.money >= shopUpgradePrice)
			{
				MainScript.money -= shopUpgradePrice;
				shopLevel++;
			}
		}
	}
}
