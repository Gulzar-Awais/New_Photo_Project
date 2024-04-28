using UnityEngine;

public class SwipeRotate: MonoBehaviour
{
    public  float  rotation_Speed = 100f;
    public  bool  Dragging = false;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void OnMouseDrag()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Dragging = true;
        }
    }
    private void Update()
    {
        if(Dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotation_Speed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * rotation_Speed * Time.deltaTime;
            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Dragging = false;
        }
    }
}

