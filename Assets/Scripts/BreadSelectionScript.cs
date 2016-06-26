using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum selectionOpen
{closed, open}

public enum breadType
{cookies, muffins, baguettes, angelCake, cornBread, bagels, applePies, cinaRolls}

public class BreadSelectionScript : MonoBehaviour{
	public Button clickPad;
	public Button breadSelectionBTN;
	public ClickerScript CS;
	public selectionOpen sO;
	public breadType BT;
	public GameObject breadList;

	public GameObject MuffinBtn;
	public GameObject BaguetteBtn;
	public GameObject AngelCakeBtn;
	public GameObject CornBreadBtn;
	public GameObject BagelBtn;
	public GameObject ApplePieBtn;
	public GameObject CinaRollBtn;

	public Text cookieText;
	public Text muffinText;
	public Text baguetteText;
	public Text angelCakeText;
	public Text cornBreadText;
	public Text bagelText;
	public Text applePieText;
	public Text cinaRollText;

	void Awake()
	{
		sO = selectionOpen.closed;

		if(UpgradeChefLevel.chefLevel == 0){
			MuffinBtn.SetActive(false);
			BaguetteBtn.SetActive(false);
			AngelCakeBtn.SetActive(false);
			CornBreadBtn.SetActive(false);
			BagelBtn.SetActive(false);
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 1){
			BaguetteBtn.SetActive(false);
			AngelCakeBtn.SetActive(false);
			CornBreadBtn.SetActive(false);
			BagelBtn.SetActive(false);
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 2){
			AngelCakeBtn.SetActive(false);
			CornBreadBtn.SetActive(false);
			BagelBtn.SetActive(false);
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 3){
			CornBreadBtn.SetActive(false);
			BagelBtn.SetActive(false);
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 4){
			BagelBtn.SetActive(false);
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 5){
			ApplePieBtn.SetActive(false);
			CinaRollBtn.SetActive(false);
		}
		else if(UpgradeChefLevel.chefLevel == 6){
			CinaRollBtn.SetActive(false);
		}
	}

	void Update()
	{
		cookieText.text = MainScript.cookieCount + "\nCookies";
		muffinText.text = MainScript.muffinCount + "\nMuffins";
		baguetteText.text = MainScript.baguetteCount + "\nBaguettes";
		angelCakeText.text = MainScript.angelCakeCount + "\nAngel\nCakes";
		cornBreadText.text = MainScript.cornBreadCount + "\nCornbread";
		bagelText.text = MainScript.bagelCount + "\nBagels";
		applePieText.text = MainScript.applePieCount + "\nApple\nPies";
		cinaRollText.text = MainScript.cinaRollCount + "\n Cinarolls";
	}

	public void BreadSelectionPressed()
	{
		if (sO == selectionOpen.closed) 
		{
			breadList.SetActive (true);
			sO = selectionOpen.open;
		}
		else if (sO == selectionOpen.open) 
		{
			breadList.SetActive (false);
			sO = selectionOpen.closed;
		}
	}

	public void CookieSelected()
	{
		BT = breadType.cookies;
		breadList.SetActive (false);
		sO = selectionOpen.closed;

	}
	public void MuffinSelected()
	{
		BT = breadType.muffins;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void BaguetteSelected()
	{
		BT = breadType.baguettes;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void AngelCakeSelected()
	{
		BT = breadType.angelCake;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void CornBreadSelected()
	{
		BT = breadType.cornBread;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void BagelSelected()
	{
		BT = breadType.bagels;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void ApplePieSelected()
	{
		BT = breadType.applePies;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}
	public void CinaRollSelected()
	{
		BT = breadType.cinaRolls;
		breadList.SetActive (false);
		sO = selectionOpen.closed;
	}

}