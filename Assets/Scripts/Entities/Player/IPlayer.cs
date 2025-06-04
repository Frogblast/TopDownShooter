using UnityEngine;

namespace TopDownShooter.Entities.Player
{
    public interface IPlayer
    {
        void Aim(Vector2 direction);
        void Attack();
        void Move(Vector2 direction);
    }
}