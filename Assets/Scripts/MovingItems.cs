using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;


public class MovingItems : MonoBehaviour //, IBeginDragHandler, IDragHandler
{
    public int t;
    [SerializeField] private Button _buttonPlay;

    // public Transform obj;
    // public Vector3 startPoint;
    // public Vector3 endPoint;
    public bool MouseDown = false;
    public static MovingItems movingItems;

    // Get instance of our 'shared class'
    public static MovingItems GetInstance() { return movingItems; }

    public void Awake()
    {
        t = 0;
    }
    // public void OnBeginDrag(PointerEventData eventData)
    // {
        

    // }


    // public void OnDrag(PointerEventData eventData)
    // {
    //     if (t == 0 && MouseDown == true) {
    //         obj.position = Camera.main.ScreenToWorldPoint(eventData.position);
    //         Debug.Log(startPoint);
    //     }
        
    //     else if (t == 1) 
    //     {
    //         obj.position = obj.position;
    //     }

    // }

    public void OnMouseDown()
    {
        MouseDown = true;
       
    }

    public void OnMouseUp()
    {
       MouseDown = false;
      
    }

    public void FixedUpdate()
    {
        Vector3 cursor = Input.mousePosition;
        cursor = Camera.main.ScreenToWorldPoint(cursor);

        if ((_buttonPlay.enabled == true))
        {
            if (MouseDown == true)
        {
            this.transform.position = cursor;
        }
        }
    }
    // public void Move2(PointerEventData eventData)
    // {
    //     if (t == 0) {
    //         obj.position = Camera.main.ScreenToWorldPoint(eventData.position);
    //     }
    //     else if (t == 1) 
    //     {
    //         obj.position = obj.position;
    //     }
    // }
    


    //  public void MoveIt(Transform obj)
    // {
    //     if (t == 0) {
    //     obj.position = Camera.main.ScreenToWorldPoint(Input.mousePosition );
    //     }
    //     else if (t == 1) 
    //     {
    //     obj.position = obj.position;

    //     }
    // }




}
