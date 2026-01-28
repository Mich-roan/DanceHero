using UnityEngine;

public class Lane : MonoBehaviour
{
    [SerializeField]
    private Transform notesPivot;
    [SerializeField]
    private GameObject notePrefab;
    public GameObject NotePrefab => notePrefab;
    public Transform NotesPivot => notesPivot;
}
