using UnityEngine;
using UnityEngine.Events;

public class NotesChecker : MonoBehaviour
{
    [SerializeField]
    private string checkAnimationName = "check";
    [SerializeField]
    private UnityEvent onNoteChecked;
    [SerializeField]
    private UnityEvent onNoteMissed;
   private GameObject currentNote;
   private Animator animator;
   private void Awake()
   {
    animator = gameObject.GetComponent<Animator>();
   }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note") && currentNote == null)
        {
            currentNote = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Note") && currentNote == other.gameObject)
        {
            currentNote = null;
        }
    }

    public void Check()
    {
        animator.Play(checkAnimationName);
        if (currentNote != null)
        {
            onNoteChecked?.Invoke();
            Destroy(currentNote);
            currentNote = null;
        }
        else
        {
            onNoteMissed?.Invoke();
        }
    }
}
