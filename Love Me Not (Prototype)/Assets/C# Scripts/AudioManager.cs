using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clip")]
    public AudioClip music;
    public AudioClip sfx;
    public AudioClip buttons;
    public AudioClip interaction;

    public float fadeDuration = 2f;
    public string[] scenesToStopMusic;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicSource.clip = music;
        StartCoroutine(FadeInMusic());
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    private IEnumerator FadeInMusic()
    {
        musicSource.volume = 0;
        musicSource.Play();

        while (musicSource.volume < 1f)
        {
            musicSource.volume += Time.deltaTime / fadeDuration;
            yield return null;
        }

        musicSource.volume = 1f;
    }

    public IEnumerator FadeOutMusic()
    {
        while (musicSource.volume > 0)
        {
            musicSource.volume -= Time.deltaTime / fadeDuration;
            yield return null;
        }

        musicSource.Stop();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        foreach (string stopMusicScene in scenesToStopMusic)
        {
            if (scene.name == stopMusicScene)
            {
                StartCoroutine(FadeOutAndDestroy());
                break;
            }
        }
    }

    private IEnumerator FadeOutAndDestroy()
    {
        yield return StartCoroutine(FadeOutMusic());
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
