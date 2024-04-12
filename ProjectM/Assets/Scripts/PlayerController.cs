using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Transform cameraTransform;
    public float moveSpeed = 10f; //�̵� �ӵ�
    public float jumpForce = 10f; //������
    public float gravity = -20f;
    public float yVelocity = 0;

    public CharacterController characterController;
    private MouseMove mousemove;
    // Start is called before the first frame update
    void Start()
    {
        mousemove = GetComponent<MouseMove>();
        //characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //ĳ���Ͱ� ���� ��� �ִ��� Ȯ��
        //isGround = characterController.isGrounded;
        Vector3 moveDirection = new Vector3(h, 0f, v);

        moveDirection = cameraTransform.TransformDirection(moveDirection);

        moveDirection *= moveSpeed;

        if(characterController.isGrounded)
        {
            yVelocity = 0;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpForce;
            }
        }
        yVelocity += (gravity * Time.deltaTime);
        moveDirection.y = yVelocity;
        characterController.Move(moveDirection * Time.deltaTime);

    }

    void UpdateRotate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        mousemove.CalculateRotation(mouseX, mouseY);
    }
}
