using UnityEngine;
using System.Collections;

public class Load2Scene : MonoBehaviour {

	private string url;
	private string assetName;
	
	void Start(){
		url = "file://"+ Application.dataPath + "/StreamingAssets/Scene2.unity3d";
		assetName = "2";
		StartCoroutine (Download ());
	}
	
	IEnumerator Download(){
		WWW www =  WWW.LoadFromCacheOrDownload (url,1);
		yield return www;
		
		AssetBundle bundle = www.assetBundle;
		www.assetBundle.Unload (false);
	}
}
