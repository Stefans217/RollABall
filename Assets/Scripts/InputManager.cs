using UnityEngine;
using UnityEngine.Events;


public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector3> OnMove = new UnityEvent<Vector3>();


    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = Vector3.zero; // intialize our input vector
       

        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector3.up; // "a += b" <=> "a = a + b"
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector3.right;
        }
        if (Input.GetKey(KeyCode.Space) && !(transform.position.y > 0.51))
        {
            inputVector += Vector3.forward;
        }
        Debug.Log(inputVector);
        OnMove?.Invoke(inputVector);

    }
}
