using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_drag : MonoBehaviour
{

    float distance = 22;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject tar;
    double x_min_d, x_max_d, z_min_d, z_max_d;
    float x_min_f, x_max_f, z_min_f, z_max_f, tmp, x, z;

    void OnMouseDrag()
    {
        print("Drag!!");
        if (canvas.activeSelf == true)
        {
            /*
            Vector3 mousePosition = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, distance);
            //print(mousePosition);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //Mathf.Clamp(objPosition.x, -1f, 1f);
            //Mathf.Clamp(objPosition.z, -1f, 1f);

            transform.position = objPosition;
            */
            Vector3 mousePosition = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, Input.mousePosition.z);

            float distanceToScreen = Camera.main.WorldToScreenPoint(transform.position).z;
            Vector3 posMove = Camera.main.ScreenToWorldPoint(
                                 new Vector3(mousePosition.x, mousePosition.y, distanceToScreen));

            transform.position = posMove;

        }
    }

    // rotate, roomscale의 경우의 수 전부 계산할 것.
    // rotate 90, rotate 270의 경우 (x,z) -> (-z, -x)
    // rotate 45의 경우는 계산 미정
    // roomscale의 비율만큼 x_min_f에 곱하면 되지 않을까.
    private void Update()
    {
        //Mathf.Clamp(transform.position.x, transform.localScale.x * 5.71f / 7 - 6.81, 6.0f)
        //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        //x_min_d = (5.71f / 7 * transform.localScale.x - 6.81) * 0.185f * tar.transform.localScale.x + 2.2358;
        //x_min_d = x_min_d / 0.864 * -1 * tar.transform.localScale.x
        //x_min_d = -(0.863f * tar.transform.localScale.x) + (0.8172f * transform.localScale.x) - 0.009;
        x_min_d = -(0.998f * tar.transform.localScale.x) + (0.8667f * transform.localScale.x) + 0.05;
        x_min_f = (float)x_min_d;


        x_max_d = (0.9996f * tar.transform.localScale.x) + (-0.9076f * transform.localScale.x) - 0.279; //45도 회전시 눈으로 보면 잘 안 보이게
        x_max_f = (float)x_max_d;

        z_min_d = -(0.9838f * tar.transform.localScale.z) + (0.9443f * transform.localScale.z) + 0.1357;
        z_min_f = (float)z_min_d;

        z_max_d = (0.992f * tar.transform.localScale.z) + (-0.9963f * transform.localScale.z) + 0.0036;
        z_max_f = (float)z_max_d;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, x_min_f, x_max_f), 0, Mathf.Clamp(transform.position.z, z_min_f, z_max_f));


        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, transform.localScale.x * 5.71f / 7 - 6.81, 6.0f), 0, Mathf.Clamp(transform.position.z, -6.0f, 6.0f));
    }

    //test
    /*
    void OnMouseDrag()
    {
        print("Drag!!");

        canvas.SetActive(false);
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
        Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
    */
}