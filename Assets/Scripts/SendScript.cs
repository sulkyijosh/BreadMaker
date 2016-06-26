using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SendScript : MonoBehaviour {
	public string sendScene;

	public void sendLevel()
	{/*
		if (Application.loadedLevelName != "2. PlayScene" && Application.loadedLevelName != "1. OpeningScene") {
			Application.LoadLevel("2. PlayScene");
		}
		if(Application.loadedLevelName == "2. PlayScene"){
			Application.LoadLevel("1. OpeningScene");
		}
		if(Application.loadedLevelName == "1. OpeningScene"){
			Application.Quit();
		}*/
		//Application.LoadLevel (sendScene);
		SceneManager.LoadScene(sendScene);
	}
	/*
	void Update () {
		if(Input.touchCount > 0){
			if(button.HitTest(Input.GetTouch(0).position)){
				if(Input.GetTouch(0).phase == TouchPhase.Began){
					Application.LoadLevel(sendScene);
				}
			}
		}
		if(button.HitTest(Input.mousePosition)){
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel (sendScene);
			}
		}
			
		if(Input.GetKey(KeyCode.Escape)){
			if(Application.platform == RuntimePlatform.Android){
				if (Application.loadedLevelName != "PlayScene" && Application.loadedLevelName != "OpeningScene") {
					Application.LoadLevel("PlayScene");
				}
				if(Application.loadedLevelName == "PlayScene"){
					Application.LoadLevel("OpeningScene");
				}
				if(Application.loadedLevelName == "OpeningScene"){
					Application.Quit();
				}
			}
		}
	}*/
}
