using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyHealthComponent))]

public class Enemy : MonoBehaviour
{
    private HealthComponent _healthComponent;

    private void Start()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }

    public HealthComponent GetHealthComponent()
    {
        return _healthComponent;
    }
}
