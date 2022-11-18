using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPresenter : IPlayerPresenter
{

    IPlayerView View;
    PlayerModel model;

    public PlayerPresenter(IPlayerView view)
    {
        model = new PlayerModel();
        View = view;
    }

    public void PlayJump()
    { 
        View.PlayAnimation("Jump");
    }

    public void Jump()
    {
        View.DoJump();
    }
    
    public void MoveLeft()
    {
        View.Left();
    }

    public void MoveRight()
    {
        View.Right();
    }

}
