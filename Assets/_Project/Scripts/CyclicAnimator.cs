using UnityEngine;

public class CyclicAnimator : MonoBehaviour
{
    public enum Mode
    {
        MoveForward = 1,
        RotateY = 2,
        ScaleUpDown = 3,
        MoveRotateScale = 4
    }

    [Header("Mode")]
    [SerializeField] private Mode mode = Mode.MoveForward;

    [Header("Move")]
    [Tooltip("Скорость движения (units/sec)")]
    [SerializeField] private float moveSpeed = 2f;

    [Header("Rotate")]
    [Tooltip("Скорость вращения вокруг Y (degres/sec)")]
    [SerializeField] private float rotateDegreesPerSecond = 90f;

    [Header("Scale")]
    [Tooltip("Скорость пульсации масштаба (cycles/sec)")]
    [SerializeField] private float scaleSpeed = 1f;

    [Tooltip("Во сколько раз увеличиваться (1.0 = без изменений)")]
    [Min(1f)]
    [SerializeField] private float scaleMultiplier = 1.5f;

    private Vector3 _startScale;

    private void Awake()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        switch (mode)
        {
            case Mode.MoveForward:
                MoveForward();
                break;

            case Mode.RotateY:
                RotateY();
                break;

            case Mode.ScaleUpDown:
                ScaleUpDown();
                break;

            case Mode.MoveRotateScale:
                MoveForward();
                RotateY();
                ScaleUpDown();
                break;
        }
    }

    private void MoveForward()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void RotateY()
    {
        float delta = rotateDegreesPerSecond * Time.deltaTime;
        transform.Rotate(0f, delta, 0f, Space.Self);
    }

    private void ScaleUpDown()
    {
        float t = Mathf.PingPong(Time.time * scaleSpeed, 1f);

        float s = Mathf.Lerp(1f, scaleMultiplier, t);

        transform.localScale = _startScale * s;
    }
}
