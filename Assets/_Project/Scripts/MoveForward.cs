using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [Tooltip("Скорость движения")]
    [SerializeField] private float moveSpeed = 2f;

    [Tooltip("Двигаться")]
    [SerializeField] private bool useLocalForward = true;

    private void Update()
    {
        Vector3 dir = useLocalForward ? transform.forward : Vector3.forward;
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
