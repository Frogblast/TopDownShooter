using UnityEngine;

namespace TopDownShooter.Items.Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        public void Shoot(Vector3 target)
        {
            target += Vector3.up; // shoot above ground...
            Debug.Log($"Weapon shoots at: {target}");

            Vector3 direction = (target - transform.position).normalized;
            Debug.DrawRay(transform.position, direction * 30f, Color.red, 2f); // lasts 2 seconds in editor
        }
    }
}
