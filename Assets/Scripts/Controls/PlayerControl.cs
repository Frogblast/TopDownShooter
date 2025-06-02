using UnityEngine;

/*
Controls any IEntity, player, enemy, npc
*/
namespace TopDownShooter.Controls
{
    public class EntityControl : MonoBehaviour, IEntityControl
    {
        private IEntity entity;

        private void Awake()
        {
            entity = GetComponent<IEntity>();
        }

        public void Move(Vector2 direction) => entity.Move(direction);
        public void Aim(Vector2 direction) => entity.Aim(direction);
        public void Attack() => entity.Attack();
    }
}
