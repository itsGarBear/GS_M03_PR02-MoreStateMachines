using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IPlayerState mCurrentState;
    void Awake()
    {
        mCurrentState = new StandingState();
        mCurrentState.Enter(this);
    }

    void Update()
    {
        mCurrentState.Execute(this);
    }
}
