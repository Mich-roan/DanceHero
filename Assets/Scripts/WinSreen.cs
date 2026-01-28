using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WinSreen : MonoBehaviour
{
   [SerializeField]
   private Text notesText;
   [SerializeField]
   private UnityEvent onWin;
   [SerializeField]
   private UnityEvent onLose;
   [SerializeField]
   private UnityEvent onHideScreen;
   public void SetNotesText(string text)
   {
    notesText.text = text;
   }
   public void ShowScreen(bool didWin)
   {
    if (didWin)
    {
        onWin?.Invoke();
    }
    else
    {
        onLose?.Invoke();
    }
   }
   public void HideScreen()
   {
    onHideScreen?.Invoke();
   }
}
