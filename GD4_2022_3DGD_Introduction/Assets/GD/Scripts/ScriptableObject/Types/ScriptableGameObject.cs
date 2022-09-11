using UnityEngine;

namespace GD
{
    public class ScriptableGameObject : ScriptableObject
    {
        [ContextMenuItem("Reset Description", "ResetDescription")]
        public string Description;

        public void ResetDescription()
        {
            Description = "";
        }
    }
}