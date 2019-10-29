using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public Image backgroundImage;
    public Image joystickImage;
    public Vector3 inputVector, startPosition, jumpVector;
    public Vector2 pos;
    public bool isJump = false;
    public float chargingTime = 0f;

    public virtual void OnDrag(PointerEventData ped)
    {
        Debug.Log("Joystick >>> OnDrag()");

        pos.x = ped.position.x - startPosition.x;
        pos.y = ped.position.y - startPosition.y;

        jumpVector = new Vector3(pos.x * 2 + 1, pos.y * 2 - 1, 0);
        jumpVector = (jumpVector.magnitude > 1.0f) ? jumpVector.normalized : jumpVector;

        // Move joystickImage
        joystickImage.rectTransform.anchoredPosition = pos;

    }

    public bool isCharge = false;
    
    public virtual void OnPointerDown(PointerEventData ped)
    {
        if (isJump)
            return;

        if (isCharge == false)
        {
            isCharge = true;
            startPosition = ped.position;
            backgroundImage.rectTransform.position = startPosition;
            // Active backgroundImage
        }
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        // Jump
        inputVector = -jumpVector;
        isJump = true;

        // Reset Data
        isCharge = false;
        startPosition = Vector3.zero;
        joystickImage.rectTransform.anchoredPosition = Vector3.zero;
    }

    public float GetHorizontalValue() { return inputVector.x; }
    public float GetVerticalValue() { return inputVector.y; }

    public bool GetIsJumping()
    {
        return isJump;
    }

    public void ResetJumpValue()
    {
        isJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCharge)
        {
            chargingTime += Time.deltaTime;
        }
    }
}
