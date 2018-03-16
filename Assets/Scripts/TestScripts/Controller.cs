using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Transform[] controlPath;
    private float pathPosition = 0;
    private Vector3 coordinateOnPath;
    private Vector2 inputPosition;
    private GameObject draggedObject;

    private void OnDrawGizmos()
    {
        iTween.DrawPath(controlPath, Color.red);
    }

    private void Update()
    {
        coordinateOnPath = iTween.PointOnPath(controlPath, pathPosition % 1);

       #region Mobile Inputs
        if (Input.touchCount > 0)
        {
            inputPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);

            RaycastHit2D hit = Physics2D.Raycast(inputPosition, inputPosition,1.0f,LayerMask.GetMask("Player"));

            if(hit.transform!=null)
            {
                draggedObject = hit.transform.gameObject;
                float distance = Vector2.Distance(inputPosition, draggedObject.transform.position);
                pathPosition += distance * 0.02f;
                draggedObject.transform.position = new Vector3(coordinateOnPath.x, coordinateOnPath.y, coordinateOnPath.z);
            }
        }
        #endregion
        
        /*#region PC inputs

        if(Input.GetMouseButtonDown(0))
        {
            inputPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(inputPosition, inputPosition, 1.0f, LayerMask.GetMask("Player"));

            if (hit.transform != null)
            {
                draggedObject = hit.transform.gameObject;
                float distance = Vector2.Distance(inputPosition, draggedObject.transform.position);
                pathPosition += distance * 0.02f;
                draggedObject.transform.position = new Vector3(coordinateOnPath.x, coordinateOnPath.y, coordinateOnPath.z);
            }
        }

        #endregion*/
    }
    private void OnMouseDrag()
    {
        inputPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(inputPosition, inputPosition, 1.0f, LayerMask.GetMask("Player"));

         if (hit.transform != null)
            {
                draggedObject = hit.transform.gameObject;
                float distance = Vector2.Distance(inputPosition, draggedObject.transform.position);
                pathPosition += distance * 0.02f;
                draggedObject.transform.position = new Vector3(coordinateOnPath.x, coordinateOnPath.y, coordinateOnPath.z);
            }
        
    }
}

