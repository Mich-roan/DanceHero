using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class CharacterData : ScriptableObject
{
    public string idleAnimationName;
    public string readyAnimationName;
}
