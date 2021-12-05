using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_add : MonoBehaviour
{
    public GameObject Object;
    public GameObject Canvas;

    public void add_obj()
    {
        // GameObject Sofa_5 = Instantiate(Object) as GameObject; code by 백
        GameObject inst = Instantiate(Object, new Vector3(0, 0, 0), Object.transform.rotation);
        inst.transform.position = new Vector3(0, 0, 0);
        Canvas.SetActive(false);
    }


}