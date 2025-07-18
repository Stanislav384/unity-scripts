using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed = 5f;
    public float runSpeed = 9f;
    float targetMovingSpeed;
    public bool canRun = true;
    public bool isRunning;
    public KeyCode runningKey = KeyCode.LeftShift;
    private Rigidbody playerRigidbody;
    void Awake()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.visible = false;
    }
    void FixedUpdate()
    {
        isRunning = canRun && Input.GetKey(runningKey);
        targetMovingSpeed = isRunning ? runSpeed : speed;
        playerRigidbody.linearVelocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.linearVelocity.y, Input.GetAxis("Vertical") * targetMovingSpeed);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
     }
}
