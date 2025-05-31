using UnityEngine;

namespace TopDownShooter.Entities.Movement
{
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float moveSpeed = 1f;
        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        public void Move(Vector2 velocity)
        {
            rb.MovePosition(velocity * moveSpeed);
        }
    }
}
