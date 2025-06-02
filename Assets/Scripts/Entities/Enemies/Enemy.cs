using TopDownShooter.Entities.Player;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity, IEnemy
{
    private Player player;
    private Vector3 moveDirection = Vector3.zero;
    private float moveSpeed = 2f;
    public float AggroRange { get; private set; } = 9;
    public float AttackRange { get; private set; } = 3;
    public bool IsAggroed { get; set; } = false;

    public void Aim(Vector2 direction)
    {
        throw new System.NotImplementedException();
    }

    public void Attack()
    {
        Debug.Log("Enemy attacks!");
    }

    public void Move(Vector2 direction)
    {
        if (IsAggroed)
        {
            EngagePlayer(direction);
        }
        else
        {
            Wander();
        }
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    private void EngagePlayer(Vector2 direction)
    {
        transform.LookAt(player.transform.position);
        Vector2 inputNormalized = direction.normalized;
        moveDirection = new Vector3(inputNormalized.x, 0f, inputNormalized.y);
    }

    private void Wander()
    {
        moveDirection = Vector3.zero;
    }

    public void SetTargetPlayer(Player player)
    {
        this.player = player;
    }
}
