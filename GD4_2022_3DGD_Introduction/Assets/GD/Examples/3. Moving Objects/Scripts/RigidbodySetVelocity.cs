using UnityEngine;

namespace GD.Examples
{
    [HelpURL("https://docs.unity3d.com/ScriptReference/Rigidbody.html")]
    public class RigidbodySetVelocity : MonoBehaviour
    {
        [Space]
        [SerializeField]
        [Tooltip("Set the magnititude of the force applied in the local forward direction")]
        [Range(1, 500)]
        private float forceMultiplier = 200;

        private Rigidbody rb;
        //// Start is called before the first frame update
        //void Start()
        //{
        //}

        // Called when the script is being loaded
        private void Awake()
        {
            //   rb = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().velocity = transform.forward * Time.deltaTime * forceMultiplier;
        }

        //// Called once every fixed update (based on refresh rate of Physics system - see Edit/Project Settings/Time)
        //void FixedUpdate()
        //{
        //}
    }
}