using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public Text uiText;
    GameObject inst;
    Vector3 loc = new Vector3(0, 0, 0);

    public void addobj(GameObject x)
    {
        if (uiText.text.Contains(x.name))
        {
            inst = Instantiate(x, loc, x.transform.rotation);
            inst.SetActive(true);
        }
    }
}
