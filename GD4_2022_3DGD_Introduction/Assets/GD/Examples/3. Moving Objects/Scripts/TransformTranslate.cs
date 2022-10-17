using UnityEngine;

namespace GD.Examples
{
    public class TransformTranslate : MonoBehaviour
    {
        //// Start is called before the first frame update
        //void Start()
        //{
        //}

        private void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}