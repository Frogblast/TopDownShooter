using TopDownShooter.Items.Weapons;
using UnityEngine;

namespace TopDownShooter.Entities.Aiming
{
    public interface IAimable
    {
        void Aim(Vector2 direction);
    }
}
