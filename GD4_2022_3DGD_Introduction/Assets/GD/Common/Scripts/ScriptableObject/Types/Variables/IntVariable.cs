using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "GD/Scriptable Objects/Variables/Int")]
    public class IntVariable : ScriptableDataType<int>
    {
        public void Add(IntVariable a)
        {
            OnChanged.Raise();
            Value += a.Value;
        }

        public void Set(IntVariable a)
        {
            // OnChanged.Raise();
            Set(a.Value);
        }

        public bool Equals(IntVariable other)
        {
            return Value.Equals(other.Value);
        }
    }
}