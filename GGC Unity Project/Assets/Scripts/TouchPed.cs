using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class TouchPed : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public Image backgroundImage;
    public Image joystickImage;

    private Image   bgImg;
    public static Vector3 startPosition;
    public static Vector3 inputVector;
    
    public static Vector2 MousePosition;
    Camera Camera;

    void Start()
    {
        startPosition = inputVector = Vector3.zero;
        bgImg = GetComponent<Image>();
        Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public void OnDrag(PointerEventData ped)
    {
        Vector2 pos;

        pos.x = ped.position.x - startPosition.x;
        pos.y = ped.position.y - startPosition.y;

        inputVector = new Vector3(pos.x, pos.y, 0);
        inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

        // Move joystickImage
        joystickImage.rectTransform.anchoredPosition = pos.normalized * 40f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundImage.gameObject.SetActive(true);
        startPosition = eventData.position;
        backgroundImage.rectTransform.position = startPosition;
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        backgroundImage.gameObject.SetActive(false);
        startPosition = Vector3.zero;
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
