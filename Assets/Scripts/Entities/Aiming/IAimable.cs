using UnityEngine;

namespace TopDownShooter.Entities.Aiming
{
    public interface IAimable
    {
        Vector3 GetTarget();
        void Aim(Vector2 direction);
    }
}
