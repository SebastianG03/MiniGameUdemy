using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInputHandler inputHandler;
    void Start()
    {
        inputHandler = GetComponent<PlayerInputHandler>();
        
    }

    void Update()
    {
        inputHandler.HorizontalMovement();
        inputHandler.VerticalMovement();
        
    }
}
