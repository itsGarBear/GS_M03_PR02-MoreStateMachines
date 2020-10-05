using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{

    float timeInAir;
    public void Enter(Player player)
    {
        player.mCurrentState = new JumpingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 10f, 0);
        Debug.Log("Entered: Jumping State");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }

        timeInAir += Time.time;

        if (Physics.Raycast(player.transform.position, Vector3.down, 0.1f) && timeInAir > Time.time)
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PartyState partyState = new PartyState();
            partyState.Enter(player);
        }
    }

}
