using UnityEngine;

public class RotateAroundY : MonoBehaviour
{
    [Tooltip("Скорость вращения")]
    [SerializeField] private float degreesPerSecond = 90f;

    [Tooltip("Вращать в вокруг собственной оси")]
    [SerializeField] private Space space = Space.Self;

    private void Update()
    {
        float delta = degreesPerSecond * Time.deltaTime;
        transform.Rotate(0f, delta, 0f, space);
    }
}
