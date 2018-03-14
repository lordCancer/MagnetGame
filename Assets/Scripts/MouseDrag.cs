using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    /*float distance = 10;

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition; 
    }*/

    public float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
