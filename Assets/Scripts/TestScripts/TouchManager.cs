using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SwipeDirection
{
    None = 0,
    Left = 1,
    Right = 2,
    Up = 4,
    Down = 8
}

public class TouchManager : MonoBehaviour {

    private static TouchManager instance;
    public static TouchManager Instance { get { return instance; } }

    public SwipeDirection Direction { set; get; }

    private Vector3 touchPosition;
    private float swipeResistanceX = 50.0f;
    private float swipeResistanceY = 100.0f;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        Direction = SwipeDirection.None;

        if(Input.GetMouseButton(0))
        {
            touchPosition = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 deltaSwipe = touchPosition - Input.mousePosition;
            if(Mathf.Abs(deltaSwipe.x)>swipeResistanceX)
            {
                Direction |= (deltaSwipe.x < 0) ? SwipeDirection.Right : SwipeDirection.Left;

            }
            if(Mathf.Abs(deltaSwipe.y)>swipeResistanceY)
            {
                Direction |= (deltaSwipe.y < 0) ? SwipeDirection.Up : SwipeDirection.Down;
            }
        }
    }

    public bool isSwiping(SwipeDirection dir)
    {
        return (Direction & dir) == dir;
    }

}
