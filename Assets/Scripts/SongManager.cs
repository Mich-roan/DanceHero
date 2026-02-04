using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class SongManager : MonoBehaviour
{
    [SerializeField]
    private Animator character;
    [SerializeField]
    private UnityEvent onSetSong;
    [SerializeField]
    private UnityEvent onSongCancel;
    [SerializeField]
    private CharacterData characterData;
     [SerializeField]
     private NotesManager notesManager;
    private SongData currentSong;
    public void Setsong(SongData song)
    {
        onSetSong?.Invoke();
        currentSong = song;
    }

    public void PlaySong()
    {
        SoundManager.instance.PlayMusic(currentSong.songName);
        character.Play(currentSong.animationName, 0, 0f);
        notesManager.StartNoteChart(currentSong.notesConfig, currentSong.speed);
    }

    public  void GetReady()
    {
       character.Play(characterData.readyAnimationName, 0, 0f);
    }

    public void StopSong()
    {
        onSongCancel?.Invoke();
        SoundManager.instance.StopMusic();
        character.Play(characterData.idleAnimationName, 0, 0f);
    }

    public void FailNote()
    {
        StopAllCoroutines();
        StartCoroutine(PlayFailAnimation());
    }

    private IEnumerator PlayFailAnimation()
    {
        SoundManager.instance.Play(characterData.failSoundName);
        character.Play(characterData.failAnimationName, 0, 0f);
        yield return new WaitForSeconds(character.GetCurrentAnimatorStateInfo(0).length);
        character.Play(currentSong.animationName, 0, 0f);
    }
}
