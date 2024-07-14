using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); 
        
    }

    public void idleAnimation(bool activate)
    {
        animator.SetBool("idle", activate);
    }

    public void runAnimation(bool isRunning)
    {
        animator.SetBool("run", isRunning);
    }

    public void jumpAnimation(bool isJumping)
    {
        animator.SetBool("jump", isJumping);
    }

    public void hurtAnimation()
    {
        animator.SetTrigger("hurt");
    }

    public void crouchAnimation(bool isCrouching)
    {
        animator.SetBool("crouch", isCrouching);
    }

    public void climbAnimation(bool isClimbing)
    {
        animator.SetBool("climb", isClimbing);
    }
}
