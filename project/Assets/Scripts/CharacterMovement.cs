using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController playerController;
    public Camera gameCamera;
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }
    // TODO: rotate towards the mouse & move with constant speed independent of click distance
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                Vector3 destination = hitInfo.point;
                Vector3 playerPosition = playerController.gameObject.transform.position;
                Vector3 moveDirection = destination - playerPosition;
                moveDirection.y = -9f; // Gravity
                playerController.Move(moveDirection * Time.deltaTime);
            }
        }
    }
}