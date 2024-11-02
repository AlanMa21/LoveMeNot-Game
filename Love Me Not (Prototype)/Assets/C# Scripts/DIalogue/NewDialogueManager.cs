using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using Ink;
using System.Linq;

public class NewDialogueManager : MonoBehaviour
{
     [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    
    [Header("choices UI")]
    [SerializeField] private GameObject[] choices;
    
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;

    public PlayerStats stats;

    public bool dialogueIsPlaying { get; private set;}
    private static NewDialogueManager instance;

    [SerializeField]
    private bool isMultiChoice;

    [SerializeField]
    private InkExternalFunctions externalFunctions;
    public bool[] bools;

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
        stats = FindObjectOfType<PlayerStats>();

        for(int i = 0; i < transform.parent.GetChild(1).GetChild(0).GetChild(0).childCount; i++)
        {
            if(transform.parent.GetChild(1).GetChild(0).GetChild(0).GetChild(i))
            {
                Choices.Add(transform.parent.GetChild(1).GetChild(0).GetChild(0).GetChild(i).gameObject);
            }
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
    public bool wasTriggered;
    public void EnterDialogueMode(TextAsset inkJSON, bool Triggered)
    {
        
        currentStory = new Story(inkJSON.text);
        if(Triggered == true)
        {
            wasTriggered = true;
        }
        //Time.timeScale = 0;
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
        if(wasTriggered)
        {
            GameObject[] a = GameObject.FindGameObjectsWithTag("Respawn");
            List<float> distances = new List<float>();
            foreach(GameObject Object in a)
            {
                distances.Add(Vector2.Distance(Object.transform.position, FindObjectOfType<BreadMovement>().transform.position));
            }
            float closest = Mathf.Min(distances.ToArray());
            int closestIndex = distances.IndexOf(closest);
            a[closestIndex].SetActive(false);
        }
        Time.timeScale = 1;
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
                if(hasPoints == false)
                {
                    DisplayChoices();
                }
               
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
    public void TurnOffPoints()
    {
        for(int i =0; i < Choices.Count; i++)
        {
            Choices[i].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease = false;
        }
    }
    public void PointIncrease(bool zero, bool one, bool two, bool three)
    {
        if(zero)
        {
            Choices[0].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease = zero;
        }
        if(one)
        {
            Choices[1].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease = one;
        }
        if(two)
        {
            Choices[2].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease = two;
        }
        if(three)
        {
            Choices[3].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease = three;
        }
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
        if(choices[choiceIndex].GetComponent<ChoiceDataHolder>().choiceData.pointIncrease)
        {
            stats.Heal(1f);
        }
    }  

    public List<GameObject> Choices = new List<GameObject>();
    public bool hasPoints;
    
}
[System.Serializable]
public class ChoiceData
{
    public bool pointIncrease;
}
