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
        float delta = _moveSpeed * Time.deltaTime;
        Space space = _useLocalForward ? Space.Self : Space.World;

        transform.Translate(Vector3.forward * delta, space);
    }
}
