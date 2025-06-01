using TopDownShooter.Items.Weapons;
using UnityEngine;

namespace TopDownShooter.Entities.Aiming
{
    public interface IShooting
    {
        void Aim(Vector2 direction);
        void Shoot(IWeapon weapon);
    }
}
