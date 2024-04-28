using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiper : MonoBehaviour
{
    private Touch Init_Touch = new Touch();
    public Camera Cam;
    private float rotX = 0f;
    private float rotY = 0f;
    private Vector3 Original_rot;


    public float rotation_Speed = 0.5f;
    public float dir = -1f;
    // Start is called before the first frame update
    void Start()
    {
        Original_rot = Cam.transform.eulerAngles;
        rotX = Original_rot.x;
        rotY = Original_rot.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                Init_Touch = touch;
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                //swaping 
                float deltaX = Init_Touch.position.x - touch.position.x;
                float deltaY = Init_Touch.position.y - touch.position.y;
                rotX -= deltaY * Time.deltaTime * rotation_Speed * dir;
                rotY += deltaX * Time.deltaTime * rotation_Speed * dir;
                rotX =  Mathf.Clamp(rotX, - 45f,45f);  
                Cam.transform.eulerAngles = new Vector3 (rotX, rotY, 0f);
            } 
            else if(touch.phase == TouchPhase.Ended)
            {
                Init_Touch = new Touch();
            }
        }
    }
}
