using UnityEngine;

public abstract class BaseBar : MonoBehaviour
{
    [SerializeField] protected Health _health;
    
    protected void OnEnable()
    {
        _health.HealthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        _health.HealthChanged -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged();
}
