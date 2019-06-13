using UnityEditor;

public class BundleBuilder : Editor{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles(){
        BuildPipeline.BuildAssetBundles(@"C:\Users\kissr\OneDrive\Asztali gép\AssetBundles", //output location
            BuildAssetBundleOptions.ChunkBasedCompression, 
            BuildTarget.StandaloneWindows64 //OS buildtarget
            ); 
    }
}
