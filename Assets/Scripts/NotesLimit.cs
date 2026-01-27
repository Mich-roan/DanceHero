using UnityEngine;
using UnityEngine.Events;

public class NotesLimit : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onNotesLimitReached;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Note"))
        {
            onNotesLimitReached?.Invoke();
            Destroy(other.gameObject);
        }
    }
}
