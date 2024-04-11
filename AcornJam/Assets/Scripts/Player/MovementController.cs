using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] CharacterController cc;
    [SerializeField] InputRecieve inputRecieve;
    [SerializeField] Transform cam;
    [SerializeField] float Speed;
    [SerializeField] float LookSpeed;
    public float CurrentSpeed { get; private set; }
    public Vector2 inputDirection { get; private set; }
    [SerializeField] float CameraHeightDif;


    void Start()
    {
        inputRecieve.MoveF = Movement;
        inputRecieve.LookF = Rotate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Movement(Vector2 direction)
    {
        inputDirection = direction;
        Vector3 moveDir = transform.forward * direction.y + transform.right * direction.x;  
        CurrentSpeed = moveDir.magnitude;
        cc.Move(moveDir * Speed * Time.deltaTime);
    }
    void Rotate(Vector2 direction)
    {
        transform.Rotate(Vector3.up * direction.x * LookSpeed  );
        cam.transform.Rotate(Vector3.left * direction.y * LookSpeed);
    }

    void CameraHeight()
    {

    }

    
}