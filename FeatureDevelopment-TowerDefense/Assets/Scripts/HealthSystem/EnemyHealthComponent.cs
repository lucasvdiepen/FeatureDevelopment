using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthComponent : HealthComponent
{
    [SerializeField] private EnemyHealthUI _enemyHealthUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    protected override void HandleTakeDamage()
    {
        base.HandleTakeDamage();

        _enemyHealthUI.UpdateUI(CurrentHealth / StartHealth);
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
}
