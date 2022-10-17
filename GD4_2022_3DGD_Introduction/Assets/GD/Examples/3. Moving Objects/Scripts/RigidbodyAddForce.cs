using UnityEngine;

namespace GD.Examples
{
    [HelpURL("https://docs.unity3d.com/Manual/Attributes.html")]
    public class RigidbodyAddForce : MonoBehaviour
    {
        [Space]
        [SerializeField]
        [Tooltip("Set the magnititude of the force applied in the local forward direction")]
        [Range(1, 200)]
        private float forceMultiplier = 100;

        [Space]
        [Header("Physics Variables")]
        [SerializeField]
        [Tooltip("This variable will ....")]
        private int x;

        private Rigidbody rb;
        //// Start is called before the first frame update
        //void Start()
        //{
        //}

        // Called when the script is being loaded
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Called once every fixed update (based on refresh rate of Physics system - see Edit/Project Settings/Time)
        private void FixedUpdate()
        {
#if UNITY_EDITOR
            Debug.Log("FixedUpdate");
#endif

            rb.AddForce(transform.forward * forceMultiplier * Time.deltaTime); //ForceMode?
        }
    }
}