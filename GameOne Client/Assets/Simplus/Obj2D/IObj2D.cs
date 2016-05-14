﻿using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public interface IObj2D
    {
        Vector2 GetPos();
        Vector2 GetPosSurface(Vector2 destination);

        bool IsFocused(Vector2 pos);
    }
}
