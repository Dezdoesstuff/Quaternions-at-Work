using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Referrence")]
    public Transform PlayerObject;
    [Space]
    [Header("Player Settings")]
    public float movementSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = PlayerObject.transform.forward * movementSpeed * Time.deltaTime;

        var horizontalInput = Input.GetAxisRaw("Horizontal");

        Vector3 PlayerObject = new Vector3(1, 1, 0).normalized;
        transform.rotation = Quaternion.AngleAxis(50, Vector3.up);

    }
}
