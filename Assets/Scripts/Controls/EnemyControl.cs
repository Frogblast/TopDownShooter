using TopDownShooter.Controls;
using TopDownShooter.Entities.Player;
using UnityEngine;

public class EnemyControl : MonoBehaviour, IEntityControl
{
    private Player player;
    private Enemy enemy;
    private float aggroRange;
    private float attackRange;

    public void Aim(Vector2 direction)
    {
        enemy.Aim(direction);
    }

    public void Attack()
    {
        enemy.Attack();
    }

    public void Move(Vector2 direction)
    {
        enemy.Move(direction);
    }

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        player = FindAnyObjectByType<Player>();
        enemy.SetTargetPlayer(player);
    }

    private void Start()
    {
        aggroRange = enemy.AggroRange;
        attackRange = enemy.AttackRange;
    }

    private void Update()
    {
        if (player == null)
        {
            Debug.Log("Player is null");
            return;
        }

        Vector3 enemyPlayerPositionsVector = player.transform.position - transform.position;
        float enemyPlayerDistance = enemyPlayerPositionsVector.magnitude;
        if (enemyPlayerDistance <= aggroRange)
        {
            enemy.IsAggroed = true;
            Move(new Vector2(enemyPlayerPositionsVector.x, enemyPlayerPositionsVector.z));
            if (enemyPlayerDistance <= attackRange)
            {
                Attack();
            }
        }
        else
        {
            enemy.IsAggroed = false;
        }
    }
}
