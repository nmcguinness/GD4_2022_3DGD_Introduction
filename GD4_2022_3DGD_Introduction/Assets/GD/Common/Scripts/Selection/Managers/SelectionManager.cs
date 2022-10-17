using UnityEngine;

namespace GD.Selection
{
    public class SelectionManager : MonoBehaviour
    {
        private IRayProvider rayProvider;
        private ISelector selector;
        private ISelectionResponse selectionResponse;

        //currently selected game object
        private Transform currentSelection;

        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            //get a ray provider
            rayProvider = GetComponent<IRayProvider>();

            //get a selector
            selector = GetComponent<ISelector>();

            //get a selection response
            selectionResponse = GetComponent<ISelectionResponse>();
        }

        // Update is called once per frame
        private void Update()
        {
            //set de-selected
            if (currentSelection != null)
            {
                selectionResponse.OnDeselect(currentSelection);
            }

            //create/get ray
            selector.Check(rayProvider.CreateRay());

            //get current selection (cast ray, do tag comparison)
            currentSelection = selector.GetSelection();

            //set selected
            if (currentSelection != null)
            {
                selectionResponse.OnSelect(currentSelection);
            }
        }
    }
}