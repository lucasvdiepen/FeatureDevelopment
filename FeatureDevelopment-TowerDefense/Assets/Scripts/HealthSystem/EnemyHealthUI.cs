using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUI : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    public void UpdateUI(float healthPercentage)
    {
        _healthSlider.value = healthPercentage;
    }
}
