using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

public class BuildAssetBundle : Editor{
	//show in the menu
	[MenuItem("BuildAssetBundle/Build Scene")]
	static void buildScene(){
		string [] levles1 = {Application.dataPath+"/Scenes/001-Login.unity"};
		BuildPipeline.BuildPlayer (levles1, Application.dataPath + "/StreamingAssets" + "/001-Login.unity3d", BuildTarget.StandaloneWindows, BuildOptions.BuildAdditionalStreamedScenes);
			AssetDatabase.Refresh ();
	
		string [] levles2 = {Application.dataPath+"/Scenes/002-Login.unity"};
		BuildPipeline.BuildPlayer (levles2, Application.dataPath + "/StreamingAssets" + "/002-Login.unity3d", BuildTarget.StandaloneWindows, BuildOptions.BuildAdditionalStreamedScenes);
		AssetDatabase.Refresh ();
	
		string [] levles3 = {Application.dataPath+"/Scenes/003-Login.unity"};
		BuildPipeline.BuildPlayer (levles3, Application.dataPath + "/StreamingAssets" + "/003-Login.unity3d", BuildTarget.StandaloneWindows, BuildOptions.BuildAdditionalStreamedScenes);
		AssetDatabase.Refresh ();


}
}