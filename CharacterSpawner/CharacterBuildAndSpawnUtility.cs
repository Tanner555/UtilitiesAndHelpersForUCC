using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Items;
using Opsive.UltimateCharacterController.Utility.Builders;
using Opsive.UltimateCharacterController.Items.Actions;
using Opsive.UltimateCharacterController.Character;
using Opsive.UltimateCharacterController.Inventory;
using Opsive.UltimateCharacterController.Character.Abilities.AI;
using Opsive.UltimateCharacterController.Objects.CharacterAssist;
//using Opsive.UltimateCharacterController.Editor.Managers;
using Abilities = Opsive.UltimateCharacterController.Character.Abilities;

#region MyUCCExtensions
public class CharacterBuildAndSpawnUtility : MonoBehaviour
{
    #region Fields
    [Header("Spawner Fields")]
    [Tooltip("Used to Spawn a Character")]
    public GameObject CharacterPrefabToSpawn;
    public string CharacterName;
    public float TimeBeforeSpawnerIsDestroyed = 0.5f;
    [Header("Gizmos Fields")]
    [Tooltip("Used to Determine Gizmos Color")]
    public bool isFriendlyCharacter = false;
    public Color FriendlyColor = Color.green;
    public Color EnemyColor = Color.red;
    public float GizmosRadius = 1.5f;
    //Used For Adding Components and setting up character
    protected GameObject spawnedGameObject = null;
    
    #endregion

    #region Properties
    protected Color gizmosColor
    {
        get
        {
            return isFriendlyCharacter ? FriendlyColor : EnemyColor;
        }
    }
    #endregion

    #region UnityMessages
    protected virtual void OnEnable()
    {
        StartCoroutine(GetReadyToInitializeCharacter());
    }

    protected virtual void OnDisable()
    {
        StopAllCoroutines();
    }

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = gizmosColor;
        Gizmos.DrawWireSphere(transform.position, GizmosRadius);
    }
    #endregion

    #region Helpers
    protected virtual GameObject SpawnCharacterPrefab(GameObject _character, string _name)
    {
        GameObject _spawnedC = Instantiate(_character, transform.position, transform.rotation) as GameObject;
        _spawnedC.name = _name;
        return _spawnedC;
    }
    #endregion

    #region Initialization
    protected virtual IEnumerator GetReadyToInitializeCharacter()
    {
        yield return new WaitForSeconds(0);
        if (CharacterPrefabToSpawn != null)
        {
            //Spawn The Given Character Prefab
            spawnedGameObject = SpawnCharacterPrefab(GetCharacterToSpawn(), GetCharacterName());
            //From CharacterBuilder-BuildCharacter
            yield return StartCoroutine(CharacterBuilder_BuildCharacter());
            //From CharacterSetup-SetupCharacter
            yield return StartCoroutine(CharacterSetup_SetupCharacter());
            //From ItemBuilder-BuildItem
            yield return StartCoroutine(ItemBuilder_BuildItem());
            //From CharacterBuilder-UpdateCharacter
            yield return StartCoroutine(CharacterBuilder_UpdateCharacter());
            //From CharacterSetup-UpdateCharacterSetup
            yield return StartCoroutine(CharacterSetup_UpdateCharacterSetup());
        }
        //Wait For All Initialization To Complete
        //Before Destroying This gameObject.
        Destroy(gameObject, TimeBeforeSpawnerIsDestroyed);
    }
    #endregion

    #region Getters
    /// <summary>
    /// Override This Method If You Need To Obtain A Character's Prefab Through Script
    /// </summary>
    /// <returns></returns>
    public virtual GameObject GetCharacterToSpawn()
    {
        return CharacterPrefabToSpawn;
    }

    /// <summary>
    /// Override This Method If You Need To Obtain A Character's Name Through Script
    /// </summary>
    /// <returns></returns>
    public virtual string GetCharacterName()
    {
        return CharacterName;
    }
    #endregion

    #region MethodsToOverride
    protected virtual IEnumerator CharacterBuilder_BuildCharacter()
    {
        yield return new WaitForSeconds(0);
    }

    protected virtual IEnumerator CharacterSetup_SetupCharacter()
    {
        yield return new WaitForSeconds(0);
    }

    protected virtual IEnumerator ItemBuilder_BuildItem()
    {
        yield return new WaitForSeconds(0);
    }

    protected virtual IEnumerator CharacterBuilder_UpdateCharacter()
    {
        yield return new WaitForSeconds(0);
    }

    protected virtual IEnumerator CharacterSetup_UpdateCharacterSetup()
    {
        yield return new WaitForSeconds(0);
    }
    #endregion
}
#endregion
