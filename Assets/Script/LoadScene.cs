using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	private string url;
	private string assetName;

	private string url1;
	private string assetName1;

	private string url2;
	private string assetName3;

	void Start(){
		url = "file://"+ Application.dataPath + "/StreamingAssets/001-Login.unity3d";
		assetName = "1";
		url1 = "file://"+ Application.dataPath + "/StreamingAssets/002-Login.unity3d";
		assetName1 = "1";
		url2 = "file://"+ Application.dataPath + "/StreamingAssets/003-Login.unity3d";
		assetName1 = "1";

		StartCoroutine (Download ());
	}

	IEnumerator Download(){
		WWW www =  WWW.LoadFromCacheOrDownload (url,1);
		yield return www;

		AssetBundle bundle = www.assetBundle;

		WWW www1 =  WWW.LoadFromCacheOrDownload (url1,1);
		yield return www1;
		
		AssetBundle bundle1 = www1.assetBundle;


		WWW www2 =  WWW.LoadFromCacheOrDownload (url2,1);
		yield return www2;
		
		AssetBundle bundle2 = www1.assetBundle;

		Application.LoadLevel("001-Login");


	//	www.assetBundle.Unload (false);
	//	www1.assetBundle.Unload (false);
	//	www2.assetBundle.Unload (false);
	}
}
