using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerView  {

    void DoJump();
    void PlayAnimation(string name);
    void Left();
    void Right();
}


