using System;
using UnityEngine;
using UnityEngine.EventSystems;

[Serializable]
public class DamageButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _health.TakeDamage(_damage);
    }
}
