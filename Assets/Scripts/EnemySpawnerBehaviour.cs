using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private EnemyBehaviour _enemy;
    [SerializeField]
    private Transform _enemyTarget;

    [SerializeField]
    private int _spawnCount = 1;
    [SerializeField]
    private float _spawnTime = 5.0f;
    private float _timer = 0.0f;

    private void Update()
    {
        if (_timer >= _spawnTime)
        {
            EnemyBehaviour spawnedEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            spawnedEnemy.Target = _enemyTarget;
            _timer = 0.0f;
        }
        _timer += Time.deltaTime;
    }
}
