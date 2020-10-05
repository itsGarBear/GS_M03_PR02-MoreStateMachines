using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaChaState : IPlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new ChaChaState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(10f, 0, 0);
        Debug.Log("Entered: ChaCha State");
    }

    public void Execute(Player player)
    {
        if(player.transform.position.x < -3f)
            player.GetComponent<Rigidbody>().velocity *= -1f;
        if (player.transform.position.x > 3f)
            player.GetComponent<Rigidbody>().velocity *= -1f;

        if (Input.GetKeyDown(KeyCode.P))
        {
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            player.transform.position = new Vector3(0f, 0.5f, 0f);
            PartyState partyState = new PartyState();
            partyState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            player.transform.position = new Vector3(0f, 0.5f, 0f);
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

    }

}
