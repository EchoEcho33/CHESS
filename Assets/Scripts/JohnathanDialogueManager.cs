using System;
using System.Collections.Generic;
using UnityEngine;

public class JohnathanDialogueManager : MonoBehaviour
{
    public enum DialogueTrigger
    {
        CHECK,
        CHECKMATE

    }
    //If Johnathan spawns in game, dialogue will be displayed differently.
    private bool JohnathanSpawned = false;
    //If Johnathan gets taken in game, his dialogue will be disabled.
    private bool JohnathanTaken = false;

    [SerializeField]
    List<String> CheckDialogue;

    [SerializeField]
    List<String> CheckmateDialogue;

    public void SpawnathanJohnathan()
    {
        JohnathanSpawned = true;
    }

    public void KillJohnathan()
    {
        JohnathanTaken = true;
    }

    public void CallDialogue(DialogueTrigger trigger)
    {
        switch (trigger)
        {
            case DialogueTrigger.CHECK:
                Check();
                break;
            case DialogueTrigger.CHECKMATE:
                CheckMate();
                break;
        }
    }

    public void Check()
    {
        if (!JohnathanTaken)
        {
            String dialogue = "Aaaand that's a wrap!";
            if (CheckDialogue != null)
            {
                int randomChoice = UnityEngine.Random.Range(0, CheckDialogue.Count);
                dialogue = CheckDialogue[randomChoice];
            }

            //TODO Connect to UI
            if (JohnathanSpawned)
            {
                Debug.Log("Spawned Dialogue: " + dialogue);
            }
            else
            {
                Debug.Log("Normal Dialogue: " + dialogue);
            }
        }
        else
        {
            // Just for testing. Else statement will be deleted entirely.
            Debug.Log("Pawnathan is dead :(");
        }
    }

    public void CheckMate()
    {
        if (!JohnathanTaken)
        {
            String dialogue = "Aaaand that's a wrap!";
            if (CheckmateDialogue != null)
            {
                int randomChoice = UnityEngine.Random.Range(0, CheckmateDialogue.Count);
                dialogue = CheckmateDialogue[randomChoice];
            }

            //TODO Connect to UI
            if (JohnathanSpawned)
            {
                Debug.Log("Spawned Dialogue: " + dialogue);
            }
            else
            {
                Debug.Log("Normal Dialogue: " + dialogue);
            }
        }
        else
        {
            // Just for testing. Else statement will be deleted entirely.
            Debug.Log("Pawnathan is dead :(");
        }
    }

}
