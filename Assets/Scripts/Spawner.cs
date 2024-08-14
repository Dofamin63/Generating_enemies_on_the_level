using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Enemy _prefab;
   [SerializeField] private Transform _target;
   [SerializeField] private float _spawnDelay;

   private WaitForSeconds _delay;

   private void Awake()
   {
      _delay = new WaitForSeconds(_spawnDelay);
      StartCoroutine(SpawnEnemy());
   }

   private IEnumerator SpawnEnemy()
   {
      while (enabled)
      {
         Enemy spawnedEnemy = Instantiate(_prefab, transform.position, Quaternion.identity);
         spawnedEnemy.SetTarget(_target);

         yield return _delay;
      }
   }
}
