using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "FloatVariable",
        menuName = "GD/Scriptable Objects/Variables/Float")]
    public class FloatVariable : ScriptableDataType<float>
    {
        public void Add(float a)
        {
            Value += a;
        }

        public void Add(FloatVariable a)
        {
            Value += a.Value;
        }

        public void Set(float a)
        {
            Value = a;
        }

        public void Set(FloatVariable a)
        {
            Value = a.Value;
        }

        public bool Equals(float other)
        {
            return Value == other;
        }

        public bool Equals(FloatVariable other)
        {
            return Value == other.Value;
        }
    }
}