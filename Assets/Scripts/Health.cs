using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health;
    
    private float _maxHealth;

    public float GetHealth => _health;
    public float GetMaxHealth => _maxHealth;
    public float GetRelativeHealth => _health / _maxHealth;
    
    public event Action healthChanged;

    private void Start()
    {
        _maxHealth = _health;
        healthChanged?.Invoke();
    }

    public void Heal(float healValue)
    {
        _health += healValue;
        
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        
        healthChanged?.Invoke();
    }

    public void TakeDamage(float damageValue)
    {
        _health -= damageValue;
        
        if (_health <= 0)
        {
            _health = 0;
        }
        
        healthChanged?.Invoke();
    }
}
