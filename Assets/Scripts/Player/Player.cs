using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    public event UnityAction<int> HealthDamaged;
    public event UnityAction Died;

    private void Start()
    {
        HealthDamaged?.Invoke(_health);
    }

    public void GetDamage(int damage)
    {
        _health -= damage;
        HealthDamaged?.Invoke(_health);
        if (_health <= 0)
            Die();
    }

    public void Die()
    {
        Died?.Invoke();
    }
}
