using UnityEngine;
using TopDownShooter.Entities.Aiming;
using TopDownShooter.Entities.Movement;
using TopDownShooter.Items.Weapons;

namespace TopDownShooter.Entities
{
    public class Player : MonoBehaviour
    {
        private IMovable movement;
        private IAimable aiming;
        private IWeapon weapon;

        private void Awake()
        {
            movement = GetComponent<IMovable>();
            aiming = GetComponent<IAimable>();
            weapon = GetComponent<IWeapon>();
        }

        public void Aim(Vector2 direction)
        {
            aiming.Aim(direction);
        }

        public void Attack()
        {

        }

        public void Move(Vector2 direction)
        {
            movement.Move(direction);
        }
    }
}