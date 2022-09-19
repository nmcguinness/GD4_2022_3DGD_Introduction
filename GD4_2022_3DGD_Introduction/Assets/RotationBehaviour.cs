using UnityEngine;

public class RotationBehaviour : MonoBehaviour
{
    //[SerializeField]
    public RotationParameters rotationParameters;

    //[SerializeField]
    //[Tooltip("Set the axis of rotation for the attached game object")]
    //private Vector3 axis = Vector3.up;

    //[SerializeField]
    //[Tooltip("Set the rotation angle")]
    //[Range(-15f, 15f)]
    //private float angleInDegrees = 1;

    //public int test;

    private void Update()
    {
        gameObject.transform.Rotate(rotationParameters.axis,
            rotationParameters.angleInDegrees * Time.fixedDeltaTime);
    }
}