using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

namespace UtilitiesAndHelpersForUCC
{
    [CustomEditor(typeof(CharacterBuildAndSpawnUtility))]
    public class CharacterEditorBuildUtilityInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            CharacterBuildAndSpawnUtility myCharacterBuilder = (CharacterBuildAndSpawnUtility)target;
            GUILayout.Label("Build Character Through Editor", EditorStyles.boldLabel);
            if (GUILayout.Button("Build Character"))
            {
                if (canBuildCharacter() && myCharacterBuilder.bBuildCharacterCompletely)
                {
                    Debug.Log("Building Character.....");
                    myCharacterBuilder.BuildCharacterThroughEditor();
                }
            }

            GUILayout.Label("Build Items Through Editor", EditorStyles.boldLabel);
            if (GUILayout.Button("Build Items"))
            {
                if (canBuildCharacter() && myCharacterBuilder.bBuildCharacterCompletely && myCharacterBuilder.bAttemptToBuildItems)
                {
                    Debug.Log("Building Items.....");
                    myCharacterBuilder.BuildCharacterItemsThroughEditor();
                }
            }
        }

        bool canBuildCharacter() {
            try
            {
                CharacterBuildAndSpawnUtility myCharacterBuilder = (CharacterBuildAndSpawnUtility)target;

                if (Application.isPlaying)
                {
                    Debug.LogWarning("Cannot Build Character Through The Editor While In Play Mode.");
                    return false;
                }

                if (myCharacterBuilder.CharacterToBuildThroughEditor == null)
                {
                    Debug.LogWarning("Please Assign CharacterToBuildThroughEditor Field Before Building Character.");
                    return false;
                }

                return true;
            }
            catch(Exception ex)
            {
                Debug.LogError("Error: " + ex.Message);
                return false;
            }
        }
        
    }
}