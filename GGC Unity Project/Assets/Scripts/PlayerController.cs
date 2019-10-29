using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject rotatePivot;
    public JoystickController joystick;
    public Vector3 moveVector = Vector3.zero;
    public float moveSpeed = 2f;

    public Vector3 originPosition = Vector3.down * 20f, originRotatePosition = new Vector3(0f, 0f, -20f);
    public Vector3 originJumpDirection;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = rotatePivot.transform.position + originPosition;
        rotatePivot.transform.rotation = Quaternion.Euler(originRotatePosition);
        moveVector = Vector3.zero;



        originJumpDirection = rotatePivot.transform.position - transform.position;
        jumpDirection = Vector3.up;
        jumpDirection.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void HandleInput()
    {
        moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        Vector3 direction = Vector3.zero;

        direction.x = joystick.GetHorizontalValue();
        direction.y = joystick.GetVerticalValue();

        if (direction.magnitude > 1)
        {
            direction.Normalize();
        }

        return direction;
    }

    public void Move()
    {
        Jump();
    }

    public float gravity = 9f;
    [SerializeField]
    private Vector3 jumpDirection;
    public Vector3 jumpVector = Vector2.zero, jumpLastVector;
    public float jumpPower, jumpMaxPower, jumpPowerRatio;
    public bool isJump = false;

    public void Jump()
    {
        if (joystick.GetIsJumping())
        {
            isJump = true;

            jumpDirection = originJumpDirection * joystick.inputVector.y;
            jumpDirection.Normalize();


            joystick.ResetJumpValue();
            jumpPower = (joystick.chargingTime * jumpPowerRatio) > jumpMaxPower ? jumpMaxPower : joystick.chargingTime * jumpPowerRatio;
            jumpVector = jumpDirection * jumpPower;
            return;
        }

        if (isJump)
        {
            jumpVector -= jumpDirection * gravity * Time.deltaTime;
            jumpLastVector = jumpVector * Time.deltaTime;
            transform.position += jumpLastVector;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.transform.name == "Floor" && isJump)
        {
            joystick.ResetJumpValue();
            transform.position -= jumpLastVector;

            jumpLastVector = jumpVector = Vector2.zero;

            joystick.chargingTime = 0f;
            isJump = false;
        }
    }
}
