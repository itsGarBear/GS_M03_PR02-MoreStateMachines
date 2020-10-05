using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new PartyState();
        Debug.Log("Entered: Party State");
    }

    public void Execute(Player player)
    {
        player.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

        if (Input.GetKeyDown(KeyCode.P))
        {
            player.GetComponent<Renderer>().material.color = GameObject.Find("Cube").GetComponent<Renderer>().material.color;
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
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
