using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Скорость движения")]
    [SerializeField] private float _moveSpeed = 2f;

    [Tooltip("Двигаться")]
    [SerializeField] private bool _useLocalForward = true;

    private void Update()
    {
        Forward();
    }

    private void Forward()
    {
        Vector3 dir = _useLocalForward ? transform.forward : Vector3.forward;
        transform.position += dir * _moveSpeed * Time.deltaTime;
    }
}
