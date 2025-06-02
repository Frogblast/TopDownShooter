using TopDownShooter.Entities.Player;

public interface IEnemy
{
    void SetTargetPlayer(Player player);
    bool IsAggroed
    {
        get;
        set;
    }
    float AggroRange 
    { 
        get;
    }
    float AttackRange
    { 
        get;
    }
}
