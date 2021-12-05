using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_light : MonoBehaviour
{
   
        float rotSpeed = 30f;

        void Update()
        {
            transform.Rotate(new Vector3(0,rotSpeed * Time.deltaTime,0));
        }
}
