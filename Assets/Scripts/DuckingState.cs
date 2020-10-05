using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new DuckingState();
        player.transform.localScale *= 0.5f;
        Debug.Log("Entered: Ducking State");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            player.transform.localScale *= 2f;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

    }

}
