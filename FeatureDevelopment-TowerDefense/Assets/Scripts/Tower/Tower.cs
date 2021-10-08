using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]

public class Tower : MonoBehaviour
{
    [SerializeField] private float _damageAmount = 5f;
    [SerializeField] private float _shootCooldown = 2f;
    [SerializeField] private Transform _turret; 

    private EnemyInRangeChecker _enemyInRangeChecker;
    private float _nextShootTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy != null)
        {
            _turret.LookAt(enemy.transform);
            if(CanShoot())
            {
                enemy.GetHealthComponent().TakeDamage(_damageAmount);
                _nextShootTime = Time.time + _shootCooldown;
            }
        }
    }

    public bool CanShoot()
    {
        return Time.time >= _nextShootTime;
    }
}
