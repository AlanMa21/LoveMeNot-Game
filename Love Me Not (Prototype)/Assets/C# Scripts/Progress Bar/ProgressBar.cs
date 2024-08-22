using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Cecil;
using Ink;


#if UNITY_EDITOR
using UnityEditor;
#endif


[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{    
 #if UNITY_EDITOR
     [MenuItem("GameObject/UI/Linear Progress Bar")]
    public static void AddLinearProgressBar()
    {
       GameObject obj = Instantiate(Resources.Load<GameObject>("UI/Linear Progress Bar"));
       obj.transform.SetParent(Selection.activeGameObject.transform, false);

    }
   #endif 
    public Stats myStats;
    public int maximum;
    public int current;
    public int minimum;
    public Image mask;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float currentOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = (float)current/(float)maximum;
        mask.fillAmount = fillAmount;

      
    }
}
