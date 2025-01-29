using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpHeight = 15f;

    public void MoveBall(Vector3 input)
    {
        Vector3 inputXZPlane = new(input.x, input.z * jumpHeight, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
