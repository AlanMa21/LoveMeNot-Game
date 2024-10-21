using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
   [Header("First Selected Button")]
   [SerializeField] private Button firstSelected;

   protected virtual void OnEnable()
   {
      SetFirstSelected(firstSelected);
   }

  /* public IEnumerator SetFirstSelected(GameObject firstSelectedObject)
   {
       EventSystem.current.SetSelectedGameObject(null);
       yield return new WaitForEndOfFrame();
       EventSystem.current.SetSelectedGameObject(firstSelectedObject);
   }*/

   public void SetFirstSelected(Button firstSelectedButton)
   {
      firstSelectedButton.Select();
   }
}
