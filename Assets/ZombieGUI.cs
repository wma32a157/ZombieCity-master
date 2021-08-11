using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Zombie))]


public class ZombieGUI : Editor
{
    private void OnSceneGUI()
    {
        Zombie zombie = (Zombie)target;
        zombie.attackDistance = Handles.RadiusHandle(zombie.transform.rotation
            , zombie.transform.position, zombie.attackDistance);

    }


}
