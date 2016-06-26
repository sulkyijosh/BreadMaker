using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeQuality: MonoBehaviour {
	int qualityUpgradePrice;
	public Text qualityPrice;
	public static int qualityLevel;
	int[] qualityUpgradeCost = {1000, 1500, 2000, 3000, 5000, 7000, 10000, 15000, 30000, 60000, 120000};
	float[] qualityUpgraded = {1f, 1.1f, 1.2f, 1.4f, 1.6f, 1.8f, 2f, 2.3f, 2.6f, 3f, 3.5f};

	void Awake(){
	}

	void Update(){
		int nextLevel = (qualityLevel + 1);
		qualityUpgradePrice = qualityUpgradeCost[qualityLevel];

		if(qualityLevel <= 9){
			qualityPrice.text = "Quality Upg: Lvl " + nextLevel + "\n" + qualityUpgradePrice;
		}
		else if (qualityLevel >= 10)
		{
			qualityPrice.text = "Quality Lvl Max";
		}
	}

	public void hireAd(){
		if(qualityLevel <= 9 && MainScript.money >= qualityUpgradePrice){
			MainScript.money -= qualityUpgradePrice;
			qualityLevel++;
			PedestrianSpawner.adUpgrade = qualityUpgraded[qualityLevel];
		}
	}
}
