using UnityEngine;

namespace TopDownShooter.Items.Weapons
{
    public class Weapon : MonoBehaviour, IWeapon
    {
        Vector3 target;
        public void Shoot(Vector3 target)
        {
            Debug.Log($"Weapon shoots at: {target}");
        }
    }
}