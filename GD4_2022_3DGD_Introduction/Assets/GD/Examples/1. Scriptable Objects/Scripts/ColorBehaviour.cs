using UnityEngine;

namespace GD.Examples
{
    public class ColorBehaviour : MonoBehaviour
    {
        [SerializeField]
        private ColorParameter colorParameter;

        private Material material;

        private void Start()
        {
            material = GetComponent<MeshRenderer>().material;
            material.color = Color.blue;
            //   material.color = colorParameter.color;
        }

        // Update is called once per frame
        private void Update()
        {
            Debug.Log("in update");
            material.color = colorParameter.color;
            //GetComponent<MeshRenderer>().material.color = colorParameter.color;
        }
    }
}