
using System.IO;

using UnityEngine;
using UnityEditor;

public class BuildPackage 
{
	public static string[] m_PackageInputPaths = 
	{
		"Assets/WebP"
	};
	public const string m_PackageOutputPath = @"./webp.unitypackage";

	[MenuItem("Build/WebP/Build Package")]
	public static void BuildUnityPackage()
	{
        AssetDatabase.Refresh();

		AssetDatabase.ExportPackage(m_PackageInputPaths, m_PackageOutputPath, ExportPackageOptions.Recurse);

		AssetDatabase.Refresh();
	}
}
