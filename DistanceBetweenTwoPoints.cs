using UnityEngine;

public class DistanceBetweenTwoPoints : MonoBehaviour
{
    public Transform target1;
    public Transform target2;

    private void Update()
    {
        Debug.Log("My Distance:" + CalculateDistance(target1.position, target2.position));
    }

    public float CalculateDistance(Vector3 target1, Vector3 target2)
    {
        Vector2 dist = new(
            target2.x - target1.x,
            target2.y - target1.y
        );

        float x = dist.x;
        float y = dist.y;

        float result = Mathf.Abs((x * x) + (y * y));

        return Mathf.Sqrt(result);
    }
}
