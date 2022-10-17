using UnityEngine;

namespace GD.Examples
{
    public class RotationBehaviour : MonoBehaviour
    {
        [SerializeField]
        private BoolReference shouldRotate;

        //[SerializeField]
        public RotationParameters rotationParameters;

        private void Update()
        {
            if (shouldRotate.Value)
            {
                gameObject.transform.Rotate(rotationParameters.axis,
                    rotationParameters.angleInDegrees * Time.fixedDeltaTime);
            }
        }
    }
}