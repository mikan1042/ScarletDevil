using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public enum States
    {
        MAIN,
        PLAY,
        DIY
    }

    States states = States.MAIN;

    private void Update()
    {
        switch (states)
        {
            case States.MAIN:
                updateMain();
                break;
            case States.PLAY:
                updatePlay();
                break;
            case States.DIY:
                updateDiy();
                break;
        }
    }

    void updateMain()
    {

    }
    void updatePlay()
    {

    }
    void updateDiy()
    {

    }
}
