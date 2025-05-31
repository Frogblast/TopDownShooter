using UnityEngine;

namespace TopDownShooter.Entities.Movement
{
    public interface IMovable
    {
        void Move(Vector2 direction);
    }
}
