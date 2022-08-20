using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField] private int _damage;

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.TryGetComponent(out Player player))
    {
      player.GetDamage(_damage);
    }
    Die();
  }

  private void Die()
  {
   gameObject.SetActive(false);
  }
}
