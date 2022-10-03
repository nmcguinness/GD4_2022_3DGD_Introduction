using UnityEngine;

/// <summary>
/// Contains a set of ScriptableObject(SO) data types (float, int, bool) and reference types that can switch between a local variable (e.g float) or reference to a shared variable (e.g. FloatVariable)
/// </summary>
namespace GD
{
    #region Generic Type

    [System.Serializable]
    public abstract class ScriptableDataType<T> : ScriptableGameObject
    {
        [ContextMenuItem("Reset Value", "ResetValue")]
        public T Value;

        public void ResetValue()
        {
            Value = default(T);
        }
    }

    #endregion Generic Type

    #region Reference Types

    [System.Serializable]
    public class BaseReference<T>
    {
        public bool UseConstant = false;
        public T ConstantValue;

        public virtual void Reset()
        {
            UseConstant = false;
            ConstantValue = default(T);
        }
    }

    [System.Serializable]
    public class BoolReference : BaseReference<bool>
    {
        public BoolVariable Variable;
        public bool Value => UseConstant ? ConstantValue : Variable.Value;

        //public int Age
        //{
        //    get
        //    {
        //        return this.age;
        //    }
        //}
    }

    [System.Serializable]
    public class FloatReference : BaseReference<float>
    {
        public FloatVariable Variable;
        public float Value => UseConstant ? ConstantValue : Variable.Value;
    }

    #endregion Reference Types
}