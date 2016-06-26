using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeMarketing: MonoBehaviour {
	int marketingUpgradePrice;
	public Text hireMarketingPrice;
	public static int marketingLevel;
	int[] marketingUpgradeCost = {1000, 1500, 2000, 3000, 5000, 7000, 10000, 15000, 30000, 60000, 120000};
	float[] marketingUpgraded = {1f, 0.95f, 0.9f, 0.85f, 0.8f, 0.75f, 0.7f, 0.6f, 0.5f, 0.3f, 0.1f, 0.1f};

	void Awake(){
	}

	void Update(){
		int nextLevel = (marketingLevel + 1);
		marketingUpgradePrice = marketingUpgradeCost[marketingLevel];

		if(marketingLevel <= 9){
			hireMarketingPrice.text = "Marketing Upg: Lvl " + nextLevel + "\n" + marketingUpgradePrice;
		}
		else if (marketingLevel >= 10)
		{
			hireMarketingPrice.text = "Marketing Lvl Max";
		}
	}

	public void hireMarketing(){
		if(marketingLevel <= 9 && MainScript.money >= marketingUpgradePrice){
			MainScript.money -= marketingUpgradePrice;
			marketingLevel++;
			PedestrianSpawner.adUpgrade = marketingUpgraded[marketingLevel];
		}
	}
}
