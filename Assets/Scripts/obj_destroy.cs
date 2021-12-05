using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_destroy : MonoBehaviour
{
    [SerializeField] GameObject obj;

    public void DestroyObj()
    {
        Destroy(obj);
    }
}
