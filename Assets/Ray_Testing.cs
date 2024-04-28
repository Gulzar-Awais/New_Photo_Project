using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray_Testing : MonoBehaviour
{
    public GameObject Last_Hit;
    public Vector3 collision = Vector3.zero;
    public List<string> Levels_Correction_text;
    public GameObject Gm;

    void Update()
    {
        var ray = new Ray(this.transform.position,this.transform.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit ,100) )
        {
            Last_Hit = hit.transform.gameObject;
            collision = hit.point;
            if(collision.x == -8.219166 && collision.y == 3.217363  && collision.z == - 6.491589)
            {
                Gm.GetComponent<GameManager>().Click_picture = true;
            }
            else
            {
                Gm.GetComponent<GameManager>().Click_picture = false;
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(collision, .9f);
    }
}

   