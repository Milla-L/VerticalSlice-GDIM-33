using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

namespace Activity
{
    public class DialogueAdvancer    : MonoBehaviour
    {
        // Singleton stuff- allows this class to be accessed from anywhere in the codebase without a reference (like a member variable)
        // do not edit this line
        public static DialogueAdvancer _Instance { get; private set; }
        [SerializeField] private DialogueNode _dialogue;

        // More Singleton stuff
        // do not edit this method
        private void Awake()
        {
            if (_Instance != null && _Instance != this)
            {
                Destroy(this);
                return;
            }

            _Instance = this;
        }

        private void Start()
        {
            EventBus.Trigger(VsEventNames.NewDialogueEvent, _dialogue);
        }

        // Button hooks up to this method
        // do not edit this method
        public void ChooseDialogue(DialogueNode nextLine)
        {
            EventBus.Trigger(VsEventNames.NewDialogueEvent, nextLine);
        }
    }
}