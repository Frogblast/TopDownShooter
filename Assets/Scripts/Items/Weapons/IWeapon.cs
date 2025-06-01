using UnityEngine;
namespace TopDownShooter.Items.Weapons
{
    internal interface IWeapon
    {
        void Shoot(Vector3 target);
    }
}