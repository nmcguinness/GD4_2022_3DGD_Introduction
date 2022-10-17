using UnityEngine;

namespace GD.Examples
{
    [HelpURL("https://docs.unity3d.com/Manual/class-TimeManager.html")]
    public class RigidbodyMovePosition : MonoBehaviour
    {
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
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
        }
    }
}