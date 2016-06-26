using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum researchType
{
	None, Chef, Click, Marketing, BreadQuality
}
public enum gambleType
{
	Money, Gold
}

public class ResearchScript : MonoBehaviour {
	int researchChance;
	[SerializeField] Text percentageText;
	int chance;
	[SerializeField] researchType RT;
	[SerializeField] gambleType GT;
	int goldPrice;

	bool upgradeSuccess;

	/*public static int chefLevel;
	public static int clickLevel;
	public static int marketingLevel;
	public static int qualityLevel;*/

	int chefUpgradeChance;
	int clickUpgradeChance;
	int marketingUpgradeChance;
	int qualityUpgradeChance;

	int[] upgradePercentage = {25, 50, 100, 150, 200, 300, 400, 500, 700, 1000};

	int[] upgradeGoldPercentage;

	public GameObject chefUpgradeSuccess;
	public GameObject clickUpgradeSuccess;
	public GameObject marketingUpgradeSuccess;
	public GameObject qualityUpgradeSuccess;

	[SerializeField] Text chefUpgradeText;
	public Text clickUpgradeText;
	public Text marketingUpgradeText;
	public Text qualityUpgradeText;

	void Awake()
	{
		upgradeSuccess = false;
	}

	void Update()
	{
		int goldPrice = chance / 5;

		int chefNext = UpgradeChefLevel.chefLevel + 1;
		int clickNext = UpgradeClick.clickLevel + 1;
		int marketingNext = UpgradeMarketing.marketingLevel + 1;
		int qualityNext = UpgradeQuality.qualityLevel + 1;

		if(GT == gambleType.Money)
		{
			if(RT == researchType.Chef)
			{
				chance = upgradePercentage[UpgradeChefLevel.chefLevel];
			}
			else if(RT == researchType.Click)
			{
				chance = upgradePercentage[UpgradeClick.clickLevel];
			}
			else if(RT == researchType.Marketing)
			{
				chance = upgradePercentage[UpgradeMarketing.marketingLevel];
			}
			else if(RT == researchType.BreadQuality)
			{
				chance = upgradePercentage[UpgradeQuality.qualityLevel];
			}
		}
		else if(GT == gambleType.Gold)
		{
			chance = 10;
		}

		float percentage = 100f / chance;

		if(RT == researchType.None)
		{
			percentageText.text = "SELECT UPGRADE TYPE" + "";
		}
		else
		{
			percentageText.text = RT + " Upgrade\nChance of success: " + string.Format("{0:0.##}", percentage) + "%";
		}

		chefUpgradeText.text = "Chef Level " + UpgradeChefLevel.chefLevel;
		clickUpgradeText.text = "Click Level " + UpgradeClick.clickLevel;
		marketingUpgradeText.text = "Marketing Level " + UpgradeMarketing.marketingLevel;
		qualityUpgradeText.text = "Bread Quality Level " + UpgradeQuality.qualityLevel;
	}

	public void Click()
	{

		if(upgradeSuccess == false){
			if(GT == gambleType.Money)
			{
				MainScript.money -= 2;
			}
			else if (GT == gambleType.Gold)
			{
				MainScript.gold -= goldPrice;
			}
			researchChance = Random.Range(1, chance);
			if(researchChance == 2)
			{
				ResearchSuccess();
			}
			else
			{
				chance -= 1;
			}
		}
	}

	public void acceptUpgrade()
	{
		upgradeSuccess = false;
		chefUpgradeSuccess.SetActive(false);
		clickUpgradeSuccess.SetActive(false);
		marketingUpgradeSuccess.SetActive(false);
		qualityUpgradeSuccess.SetActive(false);

	}

	public void SelectChef()
	{
		RT = researchType.Chef;
	}
	public void SelectClick()
	{
		RT = researchType.Click;
	}
	public void SelectMarketing()
	{
		RT = researchType.Marketing;
	}
	public void SelectBreadQuality()
	{
		RT = researchType.BreadQuality;
	}


	void ResearchSuccess()
	{
		if(RT == researchType.Chef)
		{
			upgradeSuccess = true;
			UpgradeChefLevel.chefLevel++;
			chefUpgradeSuccess.SetActive(true);
		}
		if(RT == researchType.Click)
		{
			upgradeSuccess = true;
			UpgradeClick.clickLevel++;
			clickUpgradeSuccess.SetActive(true);
		}
		if(RT == researchType.Marketing)
		{
			upgradeSuccess = true;
			UpgradeMarketing.marketingLevel++;
			marketingUpgradeSuccess.SetActive(true);
		}
		if(RT == researchType.BreadQuality)
		{
			upgradeSuccess = true;
			UpgradeQuality.qualityLevel++;
			qualityUpgradeSuccess.SetActive(true);
		}
	}
}
