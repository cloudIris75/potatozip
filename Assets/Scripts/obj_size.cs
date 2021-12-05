using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obj_size : MonoBehaviour
{
    [SerializeField] Text txt_width;
    [SerializeField] Text txt_height;
    [SerializeField] InputField inputTxt_width;
    [SerializeField] InputField inputTxt_depth;
    [SerializeField] InputField inputTxt_height;
    [SerializeField] GameObject obj;

    private float x = 1;
    private float y = 1;
    private float z = 1;

    public void Input()
    {
        x = float.Parse(inputTxt_width.text);
        y = float.Parse(inputTxt_depth.text);
        z = float.Parse(inputTxt_height.text);
        //txt_width.text = x.ToString();
        //txt_height.text = z.ToString();
        obj.transform.localScale = Vector3.one;
        obj.transform.localScale = new Vector3(x, y, z);
    }
}
