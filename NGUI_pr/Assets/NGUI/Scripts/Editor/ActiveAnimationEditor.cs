﻿//----------------------------------------------
//            NGUI: Next-Gen UI kit
// Copyright © 2011-2014 Tasharen Entertainment
//----------------------------------------------

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ActiveAnimation))]
public class ActiveAnimationEditor : Editor
{
	public override void OnInspectorGUI ()
	{
		NGUIEditorTools.SetLabelWidth(80f); //Creating active animation
		ActiveAnimation aa = target as ActiveAnimation; 
		GUILayout.Space(3f);
		NGUIEditorTools.DrawEvents("On Finished", aa, aa.onFinished);
	}
}
