using UnityEngine;

namespace TopDownShooter.Items.Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        [SerializeField] float maxDistance = 30f;

        public void Shoot(Vector3 direction)
        {
            Debug.Log($"Weapon shoots at: {direction}");

            Color rayColor = Color.red;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, maxDistance))
            {
                Debug.Log($"Hit point was: {hit.point}");
                GameObject hitObject = hit.collider.gameObject;

                if (hitObject.CompareTag("Enemy"))
                {
                    Destroy(hitObject);
                    rayColor = Color.yellow;
                }
            }
            Debug.DrawRay(transform.position, direction * 30f, rayColor, 2f); // lasts 2 seconds in editor

        }
    }
}
