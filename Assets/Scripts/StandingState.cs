using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new StandingState();
        Debug.Log("Entered: Standing State");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PartyState partyState = new PartyState();
            partyState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ChaChaState chaChaState = new ChaChaState();
            chaChaState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SpinState spinState = new SpinState();
            spinState.Enter(player);
        }
    }
}
