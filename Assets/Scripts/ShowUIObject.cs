using UnityEngine;
using System.Collections;

public class ShowUIObject : MonoBehaviour
{
    [SerializeField]
    private string animationName;
    [SerializeField]
    private InstantiatePoolObjects instantiatePool;
    public void ShowObject(Transform parent)
    {
        instantiatePool.InstantiateObject(Vector3.zero);
        Transform obj = instantiatePool.GetCurrentObject().transform;
        obj.SetParent(parent);
        obj.localPosition = Vector3.zero;
        obj.localScale = Vector3.one;

        Animator animator = obj.GetComponent<Animator>();
        StartCoroutine(PlayAnimation(animator));
    }

    private IEnumerator PlayAnimation(Animator animator)
    {
        animator.Play(animationName, 0, 0f);
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        animator.gameObject.SetActive(false);
    }
}
