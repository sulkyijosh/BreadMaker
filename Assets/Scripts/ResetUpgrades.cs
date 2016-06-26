using UnityEngine;
using System.Collections;

public class ResetUpgrades : MonoBehaviour {

	public void Reset()
	{
		UpgradeMarketing.marketingLevel = 0;
		UpgradeBakers.bakerCount = 0;
		UpgradeChefLevel.chefLevel = 0;
		UpgradeClick.clickLevel = 0;
		UpgradeShop.shopLevel = 0;
	}
}
