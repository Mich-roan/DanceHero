using UnityEngine;
using System.Collections;

public class ButtonsManager : MonoBehaviour
{
   [SerializeField]
   private Animator [] buttons;
   [SerializeField]
   private string showAnimationName = "Show";
   [SerializeField]
   private string hideAnimationName = "Hide";
   private void Start()
   {
    ShowButtons(0.5f);
   }
   public void ShowButtons(float delay = 0f)
   {
    float delayButton = 0;
    foreach(Animator button in buttons)
    {
        StartCoroutine(PlayWithDelay(button, showAnimationName, delayButton));
        delayButton+= delay;
    }
   }

   public void HideButtons(float delay = 0f)
   {
    float delayButton = 0;
    foreach(Animator button in buttons)
    {
        StartCoroutine(PlayWithDelay(button, hideAnimationName, delayButton));
        delayButton+= delay;
    }
   }

    private IEnumerator PlayWithDelay(Animator button, string animationName, float delay)
    {
        yield return new WaitForSeconds(delay);
        button.Play(animationName, 0, 0f);
    }
}
