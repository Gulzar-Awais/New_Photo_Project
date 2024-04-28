using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleInputNamespace;
public class Enabling : MonoBehaviour
{
    public float MinX, MinY;
    public float MaxX, MaxY;
    public GameObject TouchPad;
    public float Speed;
    public GameObject Gm;
    public GameObject edition;
    public GameObject DontGo;


    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinX, MaxX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
    private void OnEnable()
    {
        TouchPad.GetComponent<Touchpad>().rb = this.GetComponent<Rigidbody>();
        TouchPad.GetComponent<Touchpad>().Speed = Speed;

    }
    // Start is called before the first frame update
    private void OnDisable()
    {
        TouchPad.GetComponent<Touchpad>().rb = null;
        TouchPad.GetComponent<Touchpad>().Speed = 0f;
    }
    public void Set_Rotation()
    {
      // Debug.LogError(this.transform.position.x);
      //
      //
          float x = Mathf.Clamp(this.transform.position.x, MinX, MaxX);
         // float y = Mathf.Clamp(this.transform.position.y, MinY, MaxY);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);




        //this.transform.eulerAngles = new Vector3(
        //            x,
        //            y,
        //            transform.eulerAngles.z
        //);
    }
    private void Update()
    {
       // ClampRotationAroundXAxis(this.transform.localRotation);
    //    Set_Rotation();
        if (PlayerPrefs.GetInt("level") == 0)
        {
            if ((this.transform.position.x <= 0.4817009f && this.transform.position.x >= 0.3650367f) && (this.transform.position.y <= 0.08060178f && this.transform.position.y >= -0.004027516f))
            {
               // Debug.LogError("ok");
                Gm.GetComponent<GameManager>().Click_picture = true;
                edition.SetActive(true);
            }
            else
            {
                Gm.GetComponent<GameManager>().Click_picture = false;
                edition.SetActive(false);
            }


            //Debug.LogError(this.transform.position.x);
           if ((this.transform.position.x <= 1.429846f && this.transform.position.x >= -0.2441437f) && (this.transform.position.y <= 0.8635979f && this.transform.position.y >= -1.189152f))
               {
                TouchPad.GetComponent<Touchpad>().rb.drag = 500f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 10.5f;
                DontGo.SetActive(false);
            }
           else
           {
                TouchPad.GetComponent<Touchpad>().rb.drag = 700f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 22.5f;
                DontGo.SetActive(true);


            }
        }

        if(PlayerPrefs.GetInt("level") == 1)
        {
            if ((this.transform.rotation.eulerAngles.x <= 1.74f && this.transform.rotation.eulerAngles.x >= 1.482f) && (this.transform.rotation.eulerAngles.y <= 18 && this.transform.rotation.eulerAngles.y >= 16.995f))
            {
               // Debug.LogError("ok");
                Gm.GetComponent<GameManager>().Click_picture = true;
                edition.SetActive(true);

            }
            else
            {
                Gm.GetComponent<GameManager>().Click_picture = false;
                edition.SetActive(false);

            }

          //  Debug.LogError(this.transform.position.x);

            if ((this.transform.rotation.eulerAngles.x <= 3.04f && this.transform.rotation.eulerAngles.x >= 0.4f) && (this.transform.rotation.eulerAngles.y <= 21.2f && this.transform.rotation.eulerAngles.y >= 14.79f ))
            {
                TouchPad.GetComponent<Touchpad>().rb.drag = 500f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 10.5f;
                DontGo.SetActive(false);

            }
            else
            {
                TouchPad.GetComponent<Touchpad>().rb.drag = 700f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 22.5f;
                DontGo.SetActive(true);


            }
        } 
        
        if(PlayerPrefs.GetInt("level") == 2)
        {
            if ((this.transform.position.x <= 3.604647f && this.transform.position.x >= 3.58958f) && (this.transform.position.y <= -6.424145f && this.transform.position.y >= -6.46568f))
            {
             //   Debug.LogError("ok");
                Gm.GetComponent<GameManager>().Click_picture = true;
                edition.SetActive(true);

            }
            else
            {
                Gm.GetComponent<GameManager>().Click_picture = false;
                edition.SetActive(false);

            }


            if ((this.transform.position.x <= 3.632902f && this.transform.position.x >= 3.263116f) && (this.transform.position.y <= -6.4212 && this.transform.position.y >= -6.718046f))
            {
                TouchPad.GetComponent<Touchpad>().rb.drag = 500f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 10.5f;
                DontGo.SetActive(false);

            }
            else
            {
                TouchPad.GetComponent<Touchpad>().rb.drag = 700f;
                TouchPad.GetComponent<Touchpad>().rb.angularDrag = 22.5f;
                DontGo.SetActive(true);


            }
        }
       
    }
}
