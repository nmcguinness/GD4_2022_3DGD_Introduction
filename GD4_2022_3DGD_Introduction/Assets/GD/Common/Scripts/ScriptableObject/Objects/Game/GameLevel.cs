using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stores data relating to a level comprised of multiple scenes
/// </summary>
/// <see cref="https://blogs.unity3d.com/2020/07/01/achieve-better-scene-workflow-with-scriptableobjects/"/>
namespace GD
{
    [CreateAssetMenu(fileName = "GameLevel", menuName = "GD/Scriptable Objects/Game/Level")]
    public class GameLevel : ScriptableObject
    {
        [Header("Level Description")]
        [SerializeField]
        private string description;

        [Header("Level Objectives")]
        [SerializeField]
        private List<string> objectives;

        [Header("Scenes")]
        [SerializeField]
        private List<GameScene> gameSceneList;

        //add more level specific variables here like enemy count, spawn points for players
    }
}