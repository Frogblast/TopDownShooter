using UnityEngine;
using TopDownShooter.Entities.Aiming;
using TopDownShooter.Entities.Movement;
using TopDownShooter.Items.Weapons;

namespace TopDownShooter.Entities
{
    public class Player : MonoBehaviour
    {
        private IMovable movement;
        private IShooting aiming;
        private IWeapon weapon;

        private void Awake()
        {
            movement = GetComponent<IMovable>();
            aiming = GetComponent<IShooting>();
            weapon = GetComponentInChildren<IWeapon>();
        }

        public void Aim(Vector2 direction)
        {
            aiming.Aim(direction);
        }

        public void Attack()
        {
            aiming.Shoot(weapon);
        }

        public void Move(Vector2 direction)
        {
            movement.Move(direction);
        }
    }
}