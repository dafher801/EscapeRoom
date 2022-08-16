using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : Singleton<MainMenu>
{
    [SerializeField]
    private GameObject[] buttons;

    [SerializeField]
    private Image fadeOutImage;

    bool startFadeOut = false;

    private void Update()
    {
        if (startFadeOut)
        {
            StartCoroutine("FadeOut");

            if (fadeOutImage.color.a >= 1.0f)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void StartGame()
    {
        foreach (GameObject button in buttons)
            button.SetActive(false);

        DialogueSystem.Instance.StartDialogue("Game_Start", StartFadeOut);
    }

    public IEnumerator FadeOut()
    {
        Color color = fadeOutImage.color;

        for (int i = 0; i <= 100; i++)
        {
            color.a += Time.deltaTime * 0.01f;

            fadeOutImage.color = color;
        }

        yield return null;
    }

    public void StartFadeOut()
    {
        startFadeOut = true;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}