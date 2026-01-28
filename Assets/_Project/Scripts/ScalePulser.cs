using System;
using UnityEngine;

public class ScalePulser : MonoBehaviour
{
    [Tooltip("Скорость пульсации")]
    [SerializeField] private float _pulseSpeed = 1f;

    [Tooltip("Максимальный множитель")]
    [Min(1f)]
    [SerializeField] private float _maxScaleMultiplier = 1.5f;

    private const float MinPulse = 0f;
    private const float MaxPulse = 1f;
    private const float BaseScaleMultiplier = 1f;

    private Vector3 _baseScale;

    private void Awake()
    {
        _baseScale = transform.localScale;
    }

    private void Update()
    {
        PingPong();
    }

    private void PingPong()
    {
        float phase = Mathf.PingPong(Time.time * _pulseSpeed, MaxPulse);
        float scaleMultiplier = Mathf.Lerp(BaseScaleMultiplier, _maxScaleMultiplier, phase);

        transform.localScale = _baseScale * scaleMultiplier;
    }
}
