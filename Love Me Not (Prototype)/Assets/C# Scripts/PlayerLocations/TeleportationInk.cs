using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using System.Reflection;

public class TeleportationInk : MonoBehaviour
{
    public GameObject player;
    private Story story;

    void Start()
    {
        NewDialogueTrigger dialogueTrigger = FindObjectOfType<NewDialogueTrigger>();

        if (dialogueTrigger != null)
        {
            FieldInfo myStoryField = typeof(NewDialogueTrigger).GetField("myStory", BindingFlags.NonPublic | BindingFlags.Instance);

            if (myStoryField != null)
            {
                story = (Story)myStoryField.GetValue(dialogueTrigger);

                if (story != null)
                {
                    story.BindExternalFunction("TELEPORT", (float x, float y) => TeleportPlayer(x, y));
                }
                else
                {
                    Debug.LogError("Story in NewDialogueTrigger is null!");
                }
            }
            else
            {
                Debug.LogError("'myStory' field not found in NewDialogueTrigger!");
            }
        }
        else
        {
            Debug.LogError("NewDialogueTrigger not found in the scene!");
        }
    }

    void TeleportPlayer(float x, float y)
    {
        Vector2 teleportDestination = new Vector2(x, y);

        Debug.Log($"Teleporting player to: {teleportDestination}");

        // Teleport the player
        player.transform.position = teleportDestination;

        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
