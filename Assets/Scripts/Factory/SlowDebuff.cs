using UnityEngine;

public class SlowDebuff : Buff
{
    public float Amount = -3f;
    public SlowDebuff(float amount , float duration)
    {
        BuffName = "SlowDebuff";
        Amount = amount;
        Duration = duration;
    }
    public override void Apply(BaseEntity entity)
    {
        entity.Speed += Amount;
    }
    public override void Remove(BaseEntity entity)
    {
        entity.Speed -= Amount;
    }
}
