using System.Collections.Generic;
using Enemies;
using UnityEngine;

namespace CastleAggregate.Weapons
{
    public class ArrowsWeapon : MonoBehaviour
    {
        [SerializeField] private ArrowsSpawner spawner;

        [Space] [SerializeField] private float cooldown;

        private readonly List<Enemy> _enemies = new List<Enemy>();
        private Enemy _currentEnemy;
        private float _timer;

        private void OnEnable()
        {
            Enemy.OnDied += RemoveTargetedEnemy;
        }

        private void OnDisable()
        {
            Enemy.OnDied -= RemoveTargetedEnemy;
        }

        private void Update()
        {
            if (_enemies.Count == 0)
                return;

            _timer += Time.deltaTime;
            if (_timer >= cooldown)
            {
                _timer -= cooldown;
                Shoot();
            }
        }

        public void AddTargetedEnemy(Enemy enemy)
        {
            if (_enemies.Contains(enemy))
                return;

            _enemies.Add(enemy);
        }

        private void RemoveTargetedEnemy(Enemy enemy)
        {
            if (_enemies.Contains(enemy) == false)
                return;

            _enemies.Remove(enemy);
        }

        private void Shoot()
        {
            var enemy = GetCurrentEnemy();
            spawner.SpawnArrow(enemy.transform.position);
        }

        private Enemy GetCurrentEnemy()
        {
            return _enemies[Random.Range(0, _enemies.Count)];
        }
    }
}
