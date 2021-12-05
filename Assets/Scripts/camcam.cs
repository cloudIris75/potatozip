using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camcam : MonoBehaviour
{
    // Assign in the inspector
    public GameObject objectToRotate;
    public Slider slider;

    // Preserve the original and current orientation
    private float previousValue;

    void Awake()
    {
        // Assign a callback for when this slider changes
        this.slider.onValueChanged.AddListener(this.OnSliderChanged);

        // And current value
        this.previousValue = this.slider.value;
    }

    void OnSliderChanged(float value)
    {
        // How much we've changed
        float delta = value - this.previousValue;
        this.objectToRotate.transform.Rotate(Vector3.up * delta * 360);

        // Set our previous value for the next change
        this.previousValue = value;
    }
















    /*
    //public GameObject StartObject;
    public GameObject EndObject;
    public Transform Target;

    private void Update()
    {
        
        {
            Updatecamcam();
        }
        
    }

    void Updatecamcam()
    {
        //float distance =
        //Vector3.Distance(StartObject.transform.position, EndObject.transform.position);
        transform.RotateAround(Target.position, Vector3.up, EndObject.transform.position.x/10f);

    }  */
}
//Time.deltaTime
//StartObject.transform.position.x + EndObject.transform.position.x * Time.deltaTime