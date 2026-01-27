using UnityEngine;

public class MoveRotateScaleCombo : MonoBehaviour
{
    [Header("Move")]
    [SerializeField] private float moveSpeed = 2f;

    [Header("Rotate")]
    [SerializeField] private float degreesPerSecond = 90f;

    [Header("Scale")]
    [SerializeField] private float pulseSpeed = 1f;

    [Min(1f)]
    [SerializeField] private float maxScaleMultiplier = 1.5f;

    private Vector3 _startScale;

    private void Awake()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f, Space.Self);

        float t = Mathf.PingPong(Time.time * pulseSpeed, 1f);
        float m = Mathf.Lerp(1f, maxScaleMultiplier, t);

        transform.localScale = _startScale * m;
    }
}
