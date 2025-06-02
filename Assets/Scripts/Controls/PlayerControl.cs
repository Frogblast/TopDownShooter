using UnityEngine;
using TopDownShooter.Entities;

/*
Use this for controlling a player gameobject. 
For enemies, implement IEntityControl and make a controller for the enemy instead.
*/
namespace TopDownShooter.Controls
{
    public class PlayerControl : MonoBehaviour, IEntityControl
    {
        private Player player;

        private void Awake()
        {
            player = GetComponent<Player>();
        }

        public void Move(Vector2 direction) => player.Move(direction);
        public void Aim(Vector2 direction) => player.Aim(direction);
        public void Attack() => player.Attack();
    }
}
