using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obj_rotate : MonoBehaviour
{
    public float rotation = 45;
    // public Slider slider;
    public float a;

    public void rotation_object()
    {

        if (transform.rotation.eulerAngles.y >= 0 && transform.rotation.eulerAngles.y < 45)
        {
            transform.localEulerAngles = new Vector3(0, 45, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 45 && transform.rotation.eulerAngles.y < 90)
        {
            transform.localEulerAngles = new Vector3(0, 90, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 90 && transform.rotation.eulerAngles.y < 135)
        {
            transform.localEulerAngles = new Vector3(0, 135, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 135 && transform.rotation.eulerAngles.y < 180)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 180 && transform.rotation.eulerAngles.y < 225)
        {
            transform.localEulerAngles = new Vector3(0, -135, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 225 && transform.rotation.eulerAngles.y < 270)
        {
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 270 && transform.rotation.eulerAngles.y < 315)
        {
            transform.localEulerAngles = new Vector3(0, -45, 0);
        }
        else if (transform.rotation.eulerAngles.y >= -180 && transform.rotation.eulerAngles.y < -135)
        {
            transform.localEulerAngles = new Vector3(0, -135, 0);
        }
        else if (transform.rotation.eulerAngles.y >= -225 && transform.rotation.eulerAngles.y < -180)
        {
            transform.localEulerAngles = new Vector3(0, 270, 0);
        }
        else if (transform.rotation.eulerAngles.y >= -315 && transform.rotation.eulerAngles.y < -270)
        {
            transform.localEulerAngles = new Vector3(0, 315, 0);
        }
        else if (transform.rotation.eulerAngles.y >= 310 && transform.rotation.eulerAngles.y < 360)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
    /*
    void Update()
    {
        a = transform.rotation.eulerAngles.y / 360;
        print(a);
        slider.value = a;
    }
    */
    
}
