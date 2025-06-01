using TopDownShooter.Items.Weapons;
using UnityEngine;

namespace TopDownShooter.Entities.Shooting
{
    public class PlayerShooting : MonoBehaviour, IShooting
    {
        private float aimSpeed = 0.15f;
        private Quaternion playerRotation;
        private Vector3 target = Vector3.zero;

        public void Shoot(IWeapon weapon)
        {
            Vector3 direction = (target - transform.position).normalized;
            Vector3 heightAdjustedDirection = direction;
            if (heightAdjustedDirection.y < 0) heightAdjustedDirection.y = 0;
            weapon.Shoot(heightAdjustedDirection);
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
