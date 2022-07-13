using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueSystem : Singleton<DialogueSystem>, IPointerClickHandler
{
    [SerializeField]
    private Dialogue dialogue;

    [System.Serializable]
    public struct DialougeBaseInspector
    {
        public GameObject panel;
        public Image profile;
        public TMPro.TextMeshProUGUI text;
    }
    [SerializeField, Header("Base"), Tooltip("DON'T TOUCH THIS.")]
    private DialougeBaseInspector baseInspector;

    private bool isPlaying = false;
    private DialogueScriptSet script;
    private int index;

    // 테스트용 코드
#if UNITY_EDITOR
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StartDialogue("Test1");
        }
    }
#endif
    //

    public void OnPointerClick(PointerEventData eventData)
    {
        if (index < script.scripts.Count - 1)
        {
            index++;
            SetPanel();
        }
        else
        {
            EndDialogue();
        }
    }

    public void StartDialogue(string key)
    {
        isPlaying = true;
        baseInspector.panel.SetActive(true);
        index = 0;
        script = dialogue.FindScriptSetByKey(key);
        SetPanel();
    }

    private void EndDialogue()
    {
        isPlaying = false;
        baseInspector.panel.SetActive(false);
    }

    private void SetPanel()
    {
        baseInspector.profile.sprite = script.scripts[index].sprite;
        baseInspector.text.text = script.scripts[index].text;
    }
}
