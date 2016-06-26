using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UpgradeBakers : MonoBehaviour 
{
	public static int bakerCount;
	public Text chefUpgradePriceText;
	int bakerUpgrade = 3000;

	void Awake()
	{
	}

	void start()
	{

	}

	void Update()
	{
		if( UpgradeShop.shopLevel == 0 && bakerCount == 0)
		{
			chefUpgradePriceText.text = "Baker Level Max\nUpgrade Shop";
		}
		else if( UpgradeShop.shopLevel == 1 && bakerCount == 1)
		{
			chefUpgradePriceText.text = "Baker Level Max\nUpgrade Shop";
		}
		else if( UpgradeShop.shopLevel == 2 && bakerCount == 2)
		{
			chefUpgradePriceText.text = "Baker Level Max\nUpgrade Shop";
		}
		else if( UpgradeShop.shopLevel == 3 && bakerCount == 4)
		{
			chefUpgradePriceText.text = "Baker Level Max\nUpgrade Shop";
		}
		else if( UpgradeShop.shopLevel == 4 && bakerCount == 7)
		{
			chefUpgradePriceText.text = "Baker Level Max\nUpgrade Shop";
		}
		else if(bakerCount <= 9)
		{
			chefUpgradePriceText.text = "Hire Baker: Curr " + bakerCount + "\n$" + bakerUpgrade;
		}
		else if (bakerCount == 10)
		{
			chefUpgradePriceText.text = "Baker Max";
		}
	}



	public void UpgradeBaker()
	{
		if( UpgradeShop.shopLevel == 1 && bakerCount < 1)
		{
			if(MainScript.money >= bakerUpgrade)
			{
				MainScript.money -= bakerUpgrade;
				bakerCount++;
			}
		}
		else if( UpgradeShop.shopLevel == 2 && bakerCount < 2)
		{
			if(MainScript.money >= bakerUpgrade)
			{
				MainScript.money -= bakerUpgrade;
				bakerCount++;
			}
		}
		else if( UpgradeShop.shopLevel == 3 && bakerCount < 4)
		{
			if(MainScript.money >= bakerUpgrade)
			{
				MainScript.money -= bakerUpgrade;
				bakerCount++;
			}
		}
		else if( UpgradeShop.shopLevel == 4 && bakerCount < 7)
		{
			if(MainScript.money >= bakerUpgrade)
			{
				MainScript.money -= bakerUpgrade;
				bakerCount++;
			}
		}
		else if( UpgradeShop.shopLevel == 5 && bakerCount < 10)
		{
			if(MainScript.money >= bakerUpgrade)
			{
				MainScript.money -= bakerUpgrade;
				bakerCount++;
			}
		}
	}
}
