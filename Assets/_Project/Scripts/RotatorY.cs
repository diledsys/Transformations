using UnityEngine;

public class RotatorY : MonoBehaviour
{
    [Tooltip("Скорость вращения")]
    [SerializeField] private float _degreesPerSecond = 90f;

    [Tooltip("Вращать в вокруг собственной оси")]
    [SerializeField] private Space _space = Space.Self;

    private void Update()
    {
        TurnAround();
    }

    private void TurnAround()
    {
        float delta = _degreesPerSecond * Time.deltaTime;
        transform.Rotate(0f, delta, 0f, _space);
    }
}
