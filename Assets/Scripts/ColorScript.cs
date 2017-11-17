﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
	public Color ObjectColor;

	private Color currentColor;
	private Material materialColored;

	void Update()
	{
		if (ObjectColor != currentColor)
		{
			//helps stop memory leaks
			#if UNITY_EDITOR
			if (materialColored != null)
				UnityEditor.AssetDatabase.DeleteAsset(UnityEditor.AssetDatabase.GetAssetPath(materialColored));
			#endif

			//create a new material
			materialColored = new Material(Shader.Find("Diffuse"));
			materialColored.color = currentColor = ObjectColor;
			this.GetComponent<Renderer>().material = materialColored;
		}
	}
}
