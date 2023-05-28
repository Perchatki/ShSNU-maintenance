using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField] float sensitivity;
    [SerializeField] float speed;
    [SerializeField] Rigidbody rb;
    Ray interactionRay;
    [SerializeField] TMPro.TMP_Text interactionText;
    RaycastHit hit;
    float camX = 0;
    float camY = 0;
    Vector2 direction;
    [SerializeField] workerTalk talk;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.eulerAngles = Vector3.zero;
    }
    void Update()
    {
        camX += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        camX = Mathf.Clamp(camX, -85, 85);
        camY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        if(camX > 300)
        {
            camX -= 360;
        }
        transform.eulerAngles = new Vector3(-camX,camY, 0);
        direction = Vector2.ClampMagnitude(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw ("Vertical")), 1);
        interactionRay = GetComponent<Camera>().ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        interactionText.text = "";
        if (Physics.Raycast(interactionRay, out hit, 3))
        {
            if (hit.transform.tag.Equals("worker"))
            {
                interactionText.text = "поговорить";
                if (Input.GetMouseButtonDown(0))
                {
                    talk.interact();
                }
            }
            else if (hit.transform.tag.Equals("interactable"))
            {
                interactionText.text = "выполнить действие";
                if (Input.GetMouseButtonDown(0))
                {
                    hit.transform.SendMessage("interact");
                    talk.workIndex++;
                }
            }
        }
    }
    private void FixedUpdate()
    {
        if (direction.magnitude < 0.9f)
        {
            rb.velocity = Vector3.up * rb.velocity.y;
            rb.drag = 1;
        }
        else
        {
            rb.drag = 0;
            rb.velocity = Vector3.ProjectOnPlane((transform.forward * direction.y) + (transform.right * direction.x), Vector3.up).normalized * speed + Vector3.up * rb.velocity.y;
        }
    }
}
