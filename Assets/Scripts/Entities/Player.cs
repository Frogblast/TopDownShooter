using UnityEngine;
using TopDownShooter.Entities.Aiming;
using TopDownShooter.Entities.Movement;

namespace TopDownShooter.Entities
{
    public class Player : MonoBehaviour
    {
        private IMovable movement;
        private IAimable aiming;

        private void Awake()
        {
            movement = GetComponent<IMovable>();
            aiming = GetComponent<IAimable>();
        }

        public void Aim(Vector2 direction)
        {
            aiming.Aim(direction);
        }

        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Move(Vector2 direction)
        {
            movement.Move(direction);
        }
    }
}