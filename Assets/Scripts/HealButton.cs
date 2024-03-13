using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HealButton : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private Health _health;
    [SerializeField] private float _heal;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _health.Heal(_heal);
    }
}
