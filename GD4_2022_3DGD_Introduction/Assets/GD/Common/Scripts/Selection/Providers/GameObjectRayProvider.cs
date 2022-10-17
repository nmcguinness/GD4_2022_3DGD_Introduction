using UnityEngine;

namespace GD.Selection
{
    public class GameObjectRayProvider : MonoBehaviour, IRayProvider
    {
        [SerializeField]
        [Tooltip("Normally set to the in-game player game object")]
        private GameObject rayOrigin;

        public Ray CreateRay()
        {
            return new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
        }
    }
}