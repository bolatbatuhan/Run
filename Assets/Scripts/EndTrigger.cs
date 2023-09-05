using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager game_manager;
    private void OnTriggerEnter(Collider other)
    {
        game_manager.CompleteLevel();
    }

}
