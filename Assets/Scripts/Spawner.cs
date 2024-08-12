using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
   [SerializeField] private Enemy _prefab;
   [SerializeField] private List<Vector3> _spawnPoints;
   [SerializeField] private Vector3 _direction;
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
         Vector3 spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
         Enemy spawnedEnemy = Instantiate(_prefab, spawnPoint, Quaternion.identity);
         spawnedEnemy.transform.forward = _direction;

         yield return _delay;
      }
   }
}
