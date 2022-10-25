using Enemies;
using UnityEngine;
using UnityEngine.Events;

namespace CastleAggregate
{
    public class DetectionArea : MonoBehaviour
    {
        public UnityEvent<Enemy> onEnemyDetected;

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Enemy enemy))
            {
                DetectEnemy(enemy);
            }
        }

        private void DetectEnemy(Enemy enemy)
        {
            onEnemyDetected.Invoke(enemy);
        }
    }
}
