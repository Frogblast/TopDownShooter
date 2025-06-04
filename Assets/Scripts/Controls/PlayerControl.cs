using TopDownShooter.Entities.Player;
using UnityEngine;

/*
Controls any IEntity, player, enemy, npc
*/
namespace TopDownShooter.Controls
{
    public class PlayerControl : MonoBehaviour, IPlayerControl
    {
        private IPlayer player;

        private void Awake()
        {
            player = GetComponent<IPlayer>();
        }

        public void Move(Vector2 direction) => player.Move(direction);
        public void Aim(Vector2 direction) => player.Aim(direction);
        public void Attack() => player.Attack();
    }
}
