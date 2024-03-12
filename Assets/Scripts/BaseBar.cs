using UnityEngine;

public abstract class BaseBar : MonoBehaviour
{
    [SerializeField] protected Health _health;
    
    protected void OnEnable()
    {
        _health.healthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        _health.healthChanged -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged();
}
