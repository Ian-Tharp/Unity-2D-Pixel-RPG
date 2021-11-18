using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_Movement_Player : MonoBehaviour
{
    
    public Rigidbody2D m_Rigidbody2D;
    public float MovementSpeed;
    Vector2 Movement;
    public Animator animator;
    public Transform Interactor;

    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1) {
            animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") > 0) {
            Interactor.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetAxisRaw("Horizontal") < 0) {
            Interactor.localRotation = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetAxisRaw("Vertical") > 0) {
            Interactor.localRotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetAxisRaw("Vertical") < 0) {
            Interactor.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void FixedUpdate() {
        m_Rigidbody2D.MovePosition(m_Rigidbody2D.position + Movement * MovementSpeed * Time.deltaTime);
    }
}
