using UnityEngine;

namespace GD.Examples
{
    [CreateAssetMenu(fileName = "rotationParameters",
    menuName = "GD/Scriptable Objects/Parameters/Rotation")]
    public class RotationParameters : ScriptableObject
    {
        //  [SerializeField]
        [Tooltip("Set the axis of rotation for the attached game object")]
        public Vector3 axis = Vector3.up;

        // [SerializeField]
        [Tooltip("Set the rotation angle")]
        [Range(-15f, 15f)]
        public float angleInDegrees = 1;
    }
}