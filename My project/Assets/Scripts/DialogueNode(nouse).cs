using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueLine1", menuName = "ScriptableObjects/DialogueLine1", order = 1)]
public class DialogueNode1 : ScriptableObject
{
    
    //---------------------------------------------------------------------
    // Variables
    //---------------------------------------------------------------------
    [Tooltip("The line of dialogue the NPC says in this node.")]
    public string Line;

    [Tooltip("[Optional] The dialogue options for the player's response, and what node each response leads to.")]
    public List<PlayerReply> ReplyOptions;
}