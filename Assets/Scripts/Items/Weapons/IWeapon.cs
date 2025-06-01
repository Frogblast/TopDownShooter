using UnityEngine;
namespace TopDownShooter.Items.Weapons
{
    public interface IWeapon
    {
        void Shoot(Vector3 target);
    }
}