using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class TouchPed : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image   bgImg;
    private static Vector3 inputVector;
    
    public static Vector2 MousePosition;
    Camera Camera;

    void Start()
    {
        bgImg = GetComponent<Image>();
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
        {
            pos.x = (pos.x / 3);
            pos.y = (pos.y / 4);

            inputVector = new Vector3(pos.x * 2 + 1, pos.y * 2 - 1, 0);
            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;
        }
        MousePosition = Input.mousePosition;
        MousePosition = Camera.ScreenToWorldPoint(MousePosition);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector3.zero;
    }

    public static float GetHorizontalValue()
    {
        return inputVector.x;
    }

    public static float GetVerticalValue()
    {
        return inputVector.y;
    }
}
