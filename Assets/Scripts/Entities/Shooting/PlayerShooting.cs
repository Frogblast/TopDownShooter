using TopDownShooter.Items.Weapons;
using UnityEngine;

namespace TopDownShooter.Entities.Shooting
{
    public class PlayerShooting : MonoBehaviour, IShooting
    {
        private float aimSpeed = 0.15f;
        private Quaternion playerRotation;
        private Vector3 target;

        public void Shoot(IWeapon weapon)
        {
            weapon.Shoot(target);
        }

        public void Aim(Vector2 mouseScreenPosition)
        {
            Ray ray = Camera.main.ScreenPointToRay(mouseScreenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity))
            {
                Vector3 hitPoint = hitInfo.point;
                Vector3 direction = hitPoint - transform.position;

                target = direction;
            }
        }

        private void RotatePlayer()
        {
            Vector3 direction = target;
            if (direction.sqrMagnitude > Mathf.Epsilon)
            {
                direction.y = 0f;
                playerRotation = Quaternion.LookRotation(direction);
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, playerRotation, aimSpeed);
        }

        private void FixedUpdate()
        {
            RotatePlayer();
        }
    }
}
