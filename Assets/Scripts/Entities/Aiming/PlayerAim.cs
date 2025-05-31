using UnityEngine;

namespace TopDownShooter.Entities.Aiming
{
    public class PlayerAim : MonoBehaviour, IAimable
    {
        private float aimSpeed = 1f;

        public void Aim(Vector2 direction)
        {
            Debug.Log($"Aim direction is: {direction}");
        }
    }
}
