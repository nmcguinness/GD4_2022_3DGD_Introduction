using UnityEngine;

namespace GD.Examples
{
    [CreateAssetMenu(fileName = "colorParameter",
        menuName = "GD/Scriptable Objects/Parameters/Color")]
    public class ColorParameter : ScriptableObject
    {
        public Color color;
    }
}