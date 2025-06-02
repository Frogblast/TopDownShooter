using TopDownShooter.Items.Weapons;
using UnityEngine;

namespace TopDownShooter.Entities.Player
{
    public interface IShooting
    {
        void Aim(Vector2 direction);
        void Shoot(IWeapon weapon);
    }
}
