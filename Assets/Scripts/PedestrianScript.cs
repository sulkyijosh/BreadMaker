using UnityEngine;
using System.Collections;

public enum favBread
{cookies, muffins, baguettes, angelCake, cornBread, Bagels, applePie, cinaRolls}

public class PedestrianScript : MonoBehaviour {
	public int purchaseChance; //chance to purchase bread
	public int breadChance;
	public float walkSpeed;
	public float initWalkSpeed;
	public favBread fB;
	public GameObject breadBag;
	//GameManager GM;

	void Awake(){
		breadChance = Random.Range(1, 100);
		purchaseChance = Random.Range (0, 100); //random range number for % chance to purchase bread. if over a certain number, pedestrian will stop by for bread.
		initWalkSpeed = Random.Range(3.5f, 4f);
		walkSpeed = initWalkSpeed;

		if (breadChance >= 90) 
		{
			fB = favBread.applePie;
		}
		else if (breadChance >= 80) 
		{
			fB = favBread.Bagels;
		}
		else if (breadChance >= 70) 
		{
			fB = favBread.cornBread;
		}
		else if (breadChance >= 60) 
		{
			fB = favBread.angelCake;
		}
		else if (breadChance >= 50) 
		{
			fB = favBread.baguettes;
		}
		else if (breadChance >= 40) 
		{
			fB = favBread.muffins;
		}
		else if (breadChance >= 20) 
		{
			fB = favBread.cinaRolls;
		}
		else if (breadChance >= 0) 
		{
			fB = favBread.cookies;
		}

	}
	void Update () {

		walk ();
		if (this.gameObject.transform.position.x >= 5f) {
			Destroy (this.gameObject);
		}
		if (this.gameObject.transform.position.x <= -5f) {
			Destroy (this.gameObject);
		}
	}

	void walk(){
		this.gameObject.transform.position += transform.right * Time.deltaTime * walkSpeed;
	}

	void WalkIn(){
		walkSpeed = 0f;
		this.gameObject.transform.position += transform.up * 4.390082f;
		purchaseChance = 0;
		StartCoroutine ("Shopping");
	}

	void WalkOut(){
		walkSpeed = initWalkSpeed;
		this.gameObject.transform.position += transform.up * -4.390081f;
		this.gameObject.transform.position += transform.right * .3f;
		Purchase ();
	}

	void Purchase(){
		int purchaseAmount;
		int cookieRP = 3;
		int muffinRP = 6;
		int baguetteRP = 9;
		int angelCakeRP = 20;
		int cornBreadRP = 5;
		int bagelRP = 4;
		int applePieRP = 16;
		int cinaRollRP = 4;

		if (this.fB == favBread.cookies) {
			if (MainScript.cookieCount > 10) {
				Debug.Log ("bought cookies");
				purchaseAmount = Random.Range (1, 10);
				MainScript.cookieCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cookieRP;
				breadBag.SetActive (true);
			} else if (MainScript.cookieCount >= 1) {
				Debug.Log ("bought cookies");
				purchaseAmount = Random.Range (1, MainScript.cookieCount);
				MainScript.cookieCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cookieRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.muffins) {
			if (MainScript.muffinCount > 10) {
				Debug.Log ("bought muffins");
				purchaseAmount = Random.Range (1, 10);
				MainScript.muffinCount -= purchaseAmount;
				MainScript.money += purchaseAmount * muffinRP;
				breadBag.SetActive (true);
			} else if (MainScript.muffinCount >= 1) {
				Debug.Log ("bought muffins");
				purchaseAmount = Random.Range (1, MainScript.muffinCount);
				MainScript.muffinCount -= purchaseAmount;
				MainScript.money += purchaseAmount * muffinRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.baguettes) {
			if (MainScript.baguetteCount > 10) {
				Debug.Log ("bought baguettes");
				purchaseAmount = Random.Range (1, 10);
				MainScript.baguetteCount -= purchaseAmount;
				MainScript.money += purchaseAmount * baguetteRP;
				breadBag.SetActive (true);
			} else if (MainScript.baguetteCount >= 1) {
				Debug.Log ("bought baguettes");
				purchaseAmount = Random.Range (1, MainScript.baguetteCount);
				MainScript.baguetteCount -= purchaseAmount;
				MainScript.money += purchaseAmount * baguetteRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.angelCake) {
			if (MainScript.angelCakeCount > 10) {
				Debug.Log ("bought angelcakes");
				purchaseAmount = Random.Range (1, 10);
				MainScript.angelCakeCount -= purchaseAmount;
				MainScript.money += purchaseAmount * angelCakeRP;
				breadBag.SetActive (true);
			} else if (MainScript.angelCakeCount >= 1) {
				Debug.Log ("bought angelcakes");
				purchaseAmount = Random.Range (1, MainScript.angelCakeCount);
				MainScript.angelCakeCount -= purchaseAmount;
				MainScript.money += purchaseAmount * angelCakeRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.cornBread) {
			if (MainScript.cornBreadCount > 10) {
				Debug.Log ("bought cornbread");
				purchaseAmount = Random.Range (1, 10);
				MainScript.cornBreadCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cornBreadRP;
				breadBag.SetActive (true);
			} else if (MainScript.cornBreadCount >= 1) {
				Debug.Log ("bought cornbread");
				purchaseAmount = Random.Range (1, MainScript.cornBreadCount);
				MainScript.cornBreadCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cornBreadRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.Bagels) {
			if (MainScript.bagelCount > 10) {
				Debug.Log ("bought bagels");
				purchaseAmount = Random.Range (1, 10);
				MainScript.bagelCount -= purchaseAmount;
				MainScript.money += purchaseAmount * bagelRP;
				breadBag.SetActive (true);
			} else if (MainScript.bagelCount >= 1) {
				Debug.Log ("bought bagels");
				purchaseAmount = Random.Range (1, MainScript.bagelCount);
				MainScript.bagelCount -= purchaseAmount;
				MainScript.money += purchaseAmount * bagelRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.applePie) {
			if (MainScript.applePieCount > 10) {
				Debug.Log ("bought applepies");
				purchaseAmount = Random.Range (1, 10);
				MainScript.applePieCount -= purchaseAmount;
				MainScript.money += purchaseAmount * applePieRP;
				breadBag.SetActive (true);
			} else if (MainScript.applePieCount >= 1) {
				Debug.Log ("bought applepies");
				purchaseAmount = Random.Range (1, MainScript.applePieCount);
				MainScript.applePieCount -= purchaseAmount;
				MainScript.money += purchaseAmount * applePieRP;
				breadBag.SetActive (true);
			}
		}
		else if (this.fB == favBread.cinaRolls) {
			if (MainScript.cinaRollCount > 10) {
				Debug.Log ("bought cinarolls");
				purchaseAmount = Random.Range (1, 10);
				MainScript.cinaRollCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cinaRollRP;
				breadBag.SetActive (true);
			} else if (MainScript.cinaRollCount >= 1) {
				Debug.Log ("bought cinarolls");
				purchaseAmount = Random.Range (1, MainScript.cinaRollCount);
				MainScript.cinaRollCount -= purchaseAmount;
				MainScript.money += purchaseAmount * cinaRollRP;
				breadBag.SetActive (true);
			}
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Cashier") {
			if (purchaseChance >= 50) {
					WalkIn ();
			}
		}
	}

	private IEnumerator Shopping(){
		yield return new WaitForSeconds (1f);

		if(true){
			WalkOut();
		}
	}
}
