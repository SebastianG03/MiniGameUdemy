using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStats
{
    public float Health { get; set; }
    public float Damage { get; set; }
    public float Speed { get; set; }
    public float Energy { get; set; }
    public float JumpForce { get; set; }

    public void TakeDamage(float damage);
    public void DealDamage(IStats target);
    public void Die();
    public void ChangeHealth(float amount);

}
