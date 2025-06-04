using UnityEngine;

namespace TopDownShooter.Controls
{
    public interface IPlayerControl
    {
        void Move(Vector2 direction);
        void Aim(Vector2 direction);
        void Attack();
    }
}
