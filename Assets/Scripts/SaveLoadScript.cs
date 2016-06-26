using UnityEngine;
using System.Collections;
using System.Collections.Generic; //allows dynamic lists
using System.Runtime.Serialization.Formatters.Binary; //allows os's serialization capabilities
using System.IO; //input output
//3 added for the saveload script

public static class SaveLoadScript{ // make public static class
	
	public static void Save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.jyi"); //the "/savedGames.jyi" can be set to anything. the savedGames is set above, but the extension can be anything. savedGames.funsauce

		PlayerData data = new PlayerData();
		data.currentMoney = MainScript.money;
		data.currentCookies = MainScript.cookieCount;
		data.currentMuffins = MainScript.muffinCount;
		data.currentBaguettes = MainScript.baguetteCount;
		data.currentAngelCakes = MainScript.angelCakeCount;
		data.currentCornBread = MainScript.cornBreadCount;
		data.currentBagels = MainScript.bagelCount;
		data.currentApplePies = MainScript.applePieCount;
		data.currentCinaRolls = MainScript.cinaRollCount;
		data.currentChefLevel = UpgradeChefLevel.chefLevel;
		data.currentClickLevel = UpgradeClick.clickLevel;


		bf.Serialize (file, data);
		file.Close ();
	}
	
	public static void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/savedGames.jyi")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGames.jyi", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();

			MainScript.money = data.currentMoney;
			MainScript.cookieCount = data.currentCookies;
			MainScript.muffinCount = data.currentMuffins;
			MainScript.baguetteCount = data.currentBaguettes;
			MainScript.angelCakeCount = data.currentAngelCakes;
			MainScript.cornBreadCount = data.currentCornBread;
			MainScript.bagelCount = data.currentBagels;
			MainScript.applePieCount = data.currentApplePies;
			MainScript.cinaRollCount = data.currentCinaRolls;
			UpgradeChefLevel.chefLevel = data.currentChefLevel;
			UpgradeClick.clickLevel = data.currentClickLevel;
		}
	}
}

[System.Serializable]
class PlayerData
{
	public int currentMoney;
	public int currentCookies;
	public int currentMuffins;
	public int currentBaguettes;
	public int currentAngelCakes;
	public int currentCornBread;
	public int currentBagels;
	public int currentApplePies;
	public int currentCinaRolls;
	public int currentChefLevel;
	public int currentClickLevel;
}