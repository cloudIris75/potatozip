using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_create : MonoBehaviour
{
    public GameObject Object;
    public void create_obj()
    {
        GameObject inst = Instantiate(Object, new Vector3(0, 0, 0), Object.transform.rotation);
        inst.SetActive(true);
    }
}
