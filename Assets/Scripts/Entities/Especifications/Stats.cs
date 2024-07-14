using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Entities.Especifications
{
    public class Stats : MonoBehaviour
    {
        [SerializeField] public float Health = 100;
        [SerializeField] public float Damage = 12;
        [SerializeField] public float Speed = 5.8f;
        [SerializeField] public float Energy = 100;
        [SerializeField] public float JumpForce = 15;

        public void ChangeHealth(float amount)
        {
        }

        public void DealDamage(IStats target)
        {
        }

        public void Die()
        {
        }

        public void TakeDamage(float damage)
        {
        }
    }
}