using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        //if(Input.touchCount>0)
        //{
        //    print("touch");
        //    Touch touch = Input.GetTouch(0);
        //    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        //    touchPosition.z = 0.0f;
        //    transform.position = touchPosition;
        //}

        for(int i = 0; i<Input.touchCount; i++)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
            Debug.DrawRay(Vector3.zero, touchPosition, Color.red);
        }
    }
}
