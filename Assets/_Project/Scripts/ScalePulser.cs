using System;
using UnityEngine;

public class ScalePulser : MonoBehaviour
{
    [Tooltip("Скорость пульсации")]
    [SerializeField] private float _pulseSpeed = 1f;

    [Tooltip("Максимальный множитель")]
    [Min(1f)]
    [SerializeField] private float _maxScaleMultiplier = 1.5f;

    private Vector3 _startScale;

    private void Awake()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        PingPong();
    }

    private void PingPong()
    {
        float phase = Mathf.PingPong(Time.time * _pulseSpeed, 1f);
        float normalizedPhase = Mathf.Lerp(1f, _maxScaleMultiplier, phase);
        transform.localScale = _startScale * normalizedPhase;
    }
}
