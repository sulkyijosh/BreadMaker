using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	public static int money;
	public static int gold;
	public static int cookieCount;
	public static int muffinCount;
	public static int baguetteCount;
	public static int angelCakeCount;
	public static int cornBreadCount;
	public static int bagelCount;
	public static int applePieCount;
	public static int cinaRollCount;

	public static int CookieChefs;
	public static int MuffinChefs;
	public static int BaguetteChefs;
	public static int AngelCakeChefs;
	public static int CornBreadChefs;
	public static int BagelChefs;
	public static int ApplePieChefs;
	public static int CinaRollChefs;

	public Text currentMoneyText;
	public Text currentGoldText;

	public int cookieCost = 1;
	public int muffinCost = 2;
	public int baguetteCost = 5;
	public int angelCakeCost = 9;
	public int cornBreadCost = 6;
	public int bagelCost = 2;
	public int applePieCost = 9;
	public int cinaRollCost = 1;

	public int breadNumber = 1;
	int bakerTime = 10;

	ResearchScript RS;

	void Awake()
	{
		SaveLoadScript.Load();
	}
	void OnEnable () {
	}
	void Start(){
		if ((PlayerPrefs.GetString ("Initial")) != "Yes") {
			money = 1000;
			UpgradeChefLevel.chefLevel = 0;
			UpgradeClick.clickLevel = 0;
			UpgradeMarketing.marketingLevel = 0;
			UpgradeQuality.qualityLevel = 0;
			UpgradeBakers.bakerCount = 0;
			UpgradeShop.shopLevel = 0;
			PlayerPrefs.SetString ("Initial", "Yes");
			PlayerPrefs.Save ();
		}

		StartCoroutine(MonthlyFees());
		StartCoroutine(BakersBaking());
	}
	void Update () {
		currentMoneyText.text = "$" + money;
		currentGoldText.text = "" + gold;

		SaveLoadScript.Save ();
	}

	void BakersWorking()
	{
		int allBread = cookieCost + muffinCost + baguetteCost + angelCakeCost + cornBreadCost + bagelCost +  applePieCost + cinaRollCost ;

		if(money >= allBread * UpgradeBakers.bakerCount)
		{
			cookieCount += UpgradeBakers.bakerCount;
			muffinCount += UpgradeBakers.bakerCount;
			baguetteCount += UpgradeBakers.bakerCount;
			angelCakeCount += UpgradeBakers.bakerCount;
			cornBreadCount += UpgradeBakers.bakerCount;
			bagelCount += UpgradeBakers.bakerCount;
			applePieCount += UpgradeBakers.bakerCount;
			cinaRollCount += UpgradeBakers.bakerCount;
		}
	}

	private IEnumerator BakersBaking()
	{
		yield return new WaitForSeconds(bakerTime);

		while(true)
		{
			BakersWorking();
			yield return new WaitForSeconds(bakerTime);
		}
	}

	void RentPaid()
	{
		int rent;
		int[] rentCosts = {0, 3000, 9000, 13000, 15000, 20000, 50000};
		rent = rentCosts[UpgradeShop.shopLevel];
		money -= rent;
	}

	void WagesPaid()
	{
		int wages = 3000;
		money -= wages * UpgradeBakers.bakerCount;
	}

	private IEnumerator MonthlyFees()
	{
		yield return new WaitForSeconds(3600);

		while(true)
		{
			RentPaid();
			WagesPaid();
			yield return new WaitForSeconds(3600);
		}
	}
}
