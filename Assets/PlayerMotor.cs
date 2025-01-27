using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    public float speed = 3.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
