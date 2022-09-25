using UnityEngine;

public class MovingItem2 : MonoBehaviour
{
    public void MoveItem(Transform obj)
    {
        //var objPos = obj.position;
        //obj.position = Input.mousePosition;
        obj.position = Camera.main.WorldToScreenPoint(Input.mousePosition);
    }
}
