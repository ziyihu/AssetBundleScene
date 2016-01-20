using UnityEngine;
using System.Collections;
using System.IO;

public class OnButtonClick : MonoBehaviour {

	public void OnScene1ButtonClicked(){
			Application.LoadLevel("001-Login");
	}

	public void OnScene2ButtonClicked(){
		string scene1Path = Application.dataPath + "/Scene/002-Login.unity3d";
		//scene1 not exists

			Application.LoadLevel("002-Login");

	}

	public void OnScene3ButtonClicke(){
		string scene1Path = Application.dataPath + "/Scene/003-Login.unity3d";
		//scene1 not exists
		if (Directory.Exists (scene1Path) == true) {
			//load scene1 from the assets bundle
		} else {
			//goto scene1
			Application.LoadLevel("003-Login");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
