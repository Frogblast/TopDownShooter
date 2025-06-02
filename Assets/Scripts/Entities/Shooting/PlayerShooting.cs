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
            Vector3 heightAdjustedTarget = target;
            if (heightAdjustedTarget.y < 0) heightAdjustedTarget.y = 0;
            heightAdjustedTarget.y -= 0.5f; // Shoot slightly below the clicked surface in order to hit the enemy collider when clicking on top of them
            weapon.Shoot(heightAdjustedTarget.normalized);
        }

        public void Aim(Vector2 mouseScreenPosition)
        {
            Ray ray = Camera.main.ScreenPointToRay(mouseScreenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity))
            {
                target = hitInfo.point - transform.position;
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
