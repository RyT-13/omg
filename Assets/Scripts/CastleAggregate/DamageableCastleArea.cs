using System;
using Interfaces;
using UnityEngine;

namespace CastleAggregate
{
    public class DamageableCastleArea : MonoBehaviour, IDamageable
    {
        [SerializeField]
        private Castle castle;
        
        public void TakeDamage(float damage)
        {
            castle.TakeDamage(damage);
        }
    }
}
