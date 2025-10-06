using System;
using UnityEngine;

public class AcelerateMovement : IMovementStrategy
{
    //private float currentSpeed = 0f;
    

    public void Move(Transform transform, Player player,float direction)
    {
        //currentSpeed += Input.GetAxis("Horizontal") * player.Acceleration * Time.deltaTime;
        //player.Velocity = Mathf.Clamp(currentSpeed, -player.Velocity, player.Velocity);
        //transform.Translate(currentSpeed * Time.deltaTime, 0, 0);

        float movement = direction * (player.Velocity + player.Acceleration) * Time.deltaTime;

        transform.Translate(movement * Time.deltaTime, 0, 0);
    }
}
