using Assets.Scripts.Entities.Especifications;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour, IMovement
{
    [Range(0.1f, 1.0f)]
    public float suavizado = 0.1f;
    public float gravity = 9.8f;

    private Stats playerStats;
    private PlayerAnimationController animations;
    private float InputX = 0;
    private Rigidbody2D rb;
    private bool IsGrounded = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerStats = GetComponent<Stats>();
        animations = GetComponent<PlayerAnimationController>();
    }

    public void HorizontalMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            InputX = horizontalInput * suavizado * playerStats.Speed * (Input.GetKey(KeyCode.LeftShift) ? 2 : 1) * Time.deltaTime;
            rb.MovePosition(rb.position + new Vector2(InputX, 0));
            animations.runAnimation(true);
        }
        else
        {
            animations.runAnimation(false);
        }
    }

    public void VerticalMovement()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            IsGrounded = false;
            animations.jumpAnimation(true);
            rb.AddForce(new Vector2(0, playerStats.JumpForce * gravity));
        }

        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && !IsGrounded)
        {
            rb.AddForce(new Vector2(0, -playerStats.JumpForce * gravity));
            animations.jumpAnimation(true);
        }
        else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && IsGrounded)
        {
            animations.crouchAnimation(true);
        }
        else if ((Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)) && IsGrounded)
        {
            animations.crouchAnimation(false);
        }

        if (rb.velocity.y <= 0 && !IsGrounded)
        {
            IsGrounded = true;
            animations.jumpAnimation(false);
        }
    }
}
