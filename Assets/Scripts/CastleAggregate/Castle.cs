using UnityEngine;

namespace CastleAggregate
{
    public class Castle : MonoBehaviour
    {
        [SerializeField]
        private float _hp = BuildingsStats.AnyBuilding.Castle.hp;

        // public HealthBar healthBar;

        public void TakeDamage(float enemyDamage)
        {
            _hp -= enemyDamage;
            // healthBar.HealthUpdate(_hp);
            if (_hp <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }
}
