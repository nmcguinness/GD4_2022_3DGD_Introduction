using UnityEngine;

namespace GD.Selection
{
    public class HighlightSelectionResponse : MonoBehaviour, ISelectionResponse
    {
        [SerializeField]
        [Tooltip("Set selected (highlighted) material for game object")]
        private Material selectedMaterial;

        private Material currentOriginalMaterial;

        public void OnSelect(Transform selection)
        {
            var renderer = selection.GetComponent<Renderer>();
            if (renderer != null)
            {
                currentOriginalMaterial = renderer.material;
                renderer.material = selectedMaterial;
            }
        }

        public void OnDeselect(Transform selection)
        {
            var renderer = selection.GetComponent<Renderer>();

            //we can use c# 7.0 syntax -https://www.thomasclaudiushuber.com/2020/03/12/c-different-ways-to-check-for-null/"/>
            if (renderer != null && currentOriginalMaterial != null)
                renderer.material = currentOriginalMaterial;
        }
    }
}