using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class NewDialogueManager : MonoBehaviour
{
     [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    
    [Header("choices UI")]
    [SerializeField] private GameObject[] choices;
    
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;

    public bool dialogueIsPlaying { get; private set;}
    private static NewDialogueManager instance;

    [SerializeField]
    private bool isMultiChoice;

    [SerializeField]
    private InkExternalFunctions externalFunctions;

    private void Awake()
    {
        isMultiChoice = false;
        if (instance != null)
        {
            Debug.LogWarning("Found more than one New Dialogue Manager in the scene");
        }
        instance = this;

        if(gameObject.GetComponent<InkExternalFunctions>()!=null)
        {
            externalFunctions = gameObject.GetComponent<InkExternalFunctions>();
        }
    }

    public static NewDialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    

    private void Update()
    {
        if(!dialogueIsPlaying)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            List<Choice> currentChoices = currentStory.currentChoices;

            Debug.Log(currentChoices.Count);

            if (currentChoices.Count > 1)
            {
                isMultiChoice = true;
            }
            else
            {
                isMultiChoice = false;
                ContinueStory();
            }
            
            //ContinueStory();
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        
        currentStory = new Story(inkJSON.text);

        if (externalFunctions!=null)
        {
            externalFunctions.Bind(currentStory);
        }
        
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();
    }

    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.02f);

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    public void ContinueStory()
    {
        
        if(currentStory.canContinue)
        {
            if(isMultiChoice)
            {
                DisplayChoices();
            }
            else
            {
                dialogueText.text = currentStory.Continue();

                DisplayChoices();
            }
            
        }



        else
        {
           StartCoroutine (ExitDialogueMode());
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        if (currentChoices.Count > choices.Length)
        {
            Debug.LogError("More choices were given than the UI can support. Number of choice given: " + currentChoices.Count);

        }

        int index = 0;

        foreach(Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);

    }

    public void makeChoice(int choiceIndex)
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
    }

}
