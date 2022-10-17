using UnityEngine;

namespace GD.Examples
{
    public class MaterialChangeBehaviour : MonoBehaviour
    {
        private Material material;

        // Start is called before the first frame update
        private void Start()
        {
            material = GetComponent<MeshRenderer>().material;
        }

        /// <summary>
        /// Called by the EventManagers when the event is raised
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="target"></param>
        public void SetSomethingElse(string name, int value, bool target)
        {
            Debug.Log($"{name},{value},{target}");
        }

        /// <summary>
        /// Called by the EventManagers when the event is raised
        /// </summary>
        public void SetMaterial()
        {
            material.color = Color.red;
        }
    }
}