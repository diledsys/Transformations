using UnityEngine;

public class PulseScale : MonoBehaviour
{
    [Tooltip("Скорость пульсации")]
    [SerializeField] private float pulseSpeed = 1f;

    [Tooltip("Максимальный множитель")]
    [Min(1f)]
    [SerializeField] private float maxScaleMultiplier = 1.5f;

    private Vector3 _startScale;

    private void Awake()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        float t = Mathf.PingPong(Time.time * pulseSpeed, 1f);
        float m = Mathf.Lerp(1f, maxScaleMultiplier, t);
        transform.localScale = _startScale * m;
    }
}
