using System.Collections;
using UnityEngine;

namespace Scripts
{
    public class CandySpawner : MonoBehaviour
    {
        public Collider2D Boundary;
        public GameObject[] Candies;

        private void Start()
        {
            StartSpawning();
        }

        private void StartSpawning()
        {
            StartCoroutine(nameof(SpawningCoroutine));
        }

        private IEnumerator SpawningCoroutine()
        {
            while (!GameManager.Shared.IsGameOver)
            {
                yield return new WaitForSeconds(1);
                SpawnCandy();
            }
        }

        private void SpawnCandy()
        {
            var randIdx = Random.Range(0, Candies.Length);
            var candy = Candies[randIdx];

            var bounds = Boundary.bounds;
            var randPos = new Vector3
            {
                x = Random.Range(bounds.min.x, bounds.max.x),
                y = Boundary.bounds.max.y
            };

            Instantiate(candy, randPos, Quaternion.identity);
        }
    }
}