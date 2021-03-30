using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController playerController;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, -9f, Input.GetAxis("Vertical") * moveSpeed);
        playerController.Move(moveDirection * Time.deltaTime);
    }
}
