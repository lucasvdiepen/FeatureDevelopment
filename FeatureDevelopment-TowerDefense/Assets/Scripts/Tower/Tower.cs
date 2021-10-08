using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]

public class Tower : MonoBehaviour
{
    private EnemyInRangeChecker _enemyInRangeChecker;

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
            print(enemy.name);
        }
    }
}
