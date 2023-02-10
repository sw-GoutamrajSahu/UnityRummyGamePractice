using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    /* [SerializeField]
     private Canvas canvas;*/

    private GameObject canvas ;
    Camera cam;
    private Transform currentTransform;
    // private Camera cam;
    private void Start()
    {
        canvas = GameObject.FindGameObjectsWithTag("MainCanvas")[0];
        cam = Camera.current;
        canvas.GetComponent<Camera>();
       /* currentTransform = gameObject.GetComponent<RectTransform>();
        Debug.Log(currentTransform.position);*/
    }


    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            pointerData.position,
            cam,
            out position);
        transform.position = canvas.transform.TransformPoint(position);
    }

    public void CheckAndAdjustPosition()
    {
       // gameObject.GetComponent<RectTransform>().position = currentTransform.position;
        //Debug.Log(gameObject.transform.position);
        Debug.Log("Got Drag end");
    }
}
