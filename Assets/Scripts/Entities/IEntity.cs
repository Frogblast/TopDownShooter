using UnityEngine;

public interface IEntity
{
    void Aim(Vector2 direction);
    void Attack();
    void Move(Vector2 direction);
}
