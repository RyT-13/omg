using UnityEngine;

namespace CastleAggregate.Weapons
{
    public class ArrowsSpawner : MonoBehaviour
    {
        [SerializeField] private Arrow arrowPref;

        [SerializeField] private Transform arrowShotPoint;

        public void SpawnArrow(Vector2 target)
        {
            var direction = target - (Vector2)transform.position;
            var rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90);
            Instantiate(arrowPref, arrowShotPoint.position, rotation);
        }

        // метод - херня... переделай через for.
        // public void CreateArrowWave()
        // {
        //     var i = 0;
        //     while (i < 12)
        //     {
        //         print(flagCreateArrowWave);
        //         var rotation = Quaternion.Euler(0, 0, 30 * i);
        //         Instantiate(arrowPref, arrowShotPoint.position, rotation);
        //         i++;
        //     }
        // }
    }
}
