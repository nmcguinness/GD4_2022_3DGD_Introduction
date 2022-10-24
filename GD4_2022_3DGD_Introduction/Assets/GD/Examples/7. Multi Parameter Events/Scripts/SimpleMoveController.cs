using UnityEngine;

namespace GD.Examples
{
    public class SimpleMoveController : MonoBehaviour
    {
        [SerializeField]
        private float speed = 1.25f;

        private CharacterController characterController;
        private Animator animator;
        private Vector3 movement;

        private void Start()
        {
            characterController = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }

        private void FixedUpdate()
        {
            if (movement.magnitude > 0)
            {
                movement.Normalize();
                movement *= speed * Time.deltaTime;
                characterController.Move(movement);
            }

            if (movement != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 0.01f * Time.deltaTime);
            }

            animator.SetFloat("VelocityX", Vector3.Dot(movement.normalized, transform.right), 0.1f, Time.deltaTime);
            animator.SetFloat("VelocityZ", Vector3.Dot(movement.normalized, transform.forward), 0.1f, Time.deltaTime);
        }
    }
}