using UnityEngine;

public sealed class LaserAmmunitiom : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    [SerializeField] private float _distance;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    public void SetLineRenderer(Transform point, Vector3 direction)
    {
        Ray2D ray = new Ray2D(point.position, direction);

        _lineRenderer.SetPosition(0, ray.origin);

        var hit = Physics2D.Raycast(ray.origin, direction, _distance);

        _lineRenderer.SetPosition(1, hit.collider ? hit.point : ray.GetPoint(_distance));
    }
}