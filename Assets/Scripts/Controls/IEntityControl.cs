using UnityEngine;

namespace TopDownShooter.Controls
{
    public interface IEntityControl
    {
        void Move(Vector2 direction);
        void Look(Vector2 direction);
        void Attack();
    }
}
