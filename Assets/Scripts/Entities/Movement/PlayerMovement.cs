using UnityEngine;

namespace TopDownShooter.Entities.Movement
{
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float moveSpeed = 1f;
        private Rigidbody rb;
        private Vector3 moveDirection = Vector3.zero;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Move(Vector2 direction)
        {
            Vector2 inputNormalized = direction.normalized;
            moveDirection = new Vector3(inputNormalized.x, 0f, inputNormalized.y);
        }

        private void FixedUpdate()
        {
           transform.Translate(moveDirection*moveSpeed*Time.deltaTime, Space.World);
        }
    }
}
