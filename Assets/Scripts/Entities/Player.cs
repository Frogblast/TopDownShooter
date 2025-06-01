using UnityEngine;
using TopDownShooter.Entities.Shooting;
using TopDownShooter.Entities.Movement;
using TopDownShooter.Items.Weapons;

namespace TopDownShooter.Entities
{
    public class Player : MonoBehaviour
    {
        private IMovable movement;
        private IShooting shooting;
        private IWeapon weapon;

        private void Awake()
        {
            movement = GetComponent<IMovable>();
            shooting = GetComponent<IShooting>();
            weapon = GetComponentInChildren<IWeapon>();
        }

        public void Aim(Vector2 direction)
        {
            shooting.Aim(direction);
        }

        public void Attack()
        {
            shooting.Shoot(weapon);
        }

        public void Move(Vector2 direction)
        {
            movement.Move(direction);
        }
    }
}