using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeathDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _healthBar;

    private void OnEnable()
    {
        _player.HealthDamaged += HealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthDamaged -= HealthChanged;
    }

    private void HealthChanged(int health)
    {
        _healthBar.text = health.ToString();
    }
}
