using System.Globalization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class TextManager : MonoBehaviour
{
   public int scores;
   private Text label;
   public UnityEvent startEvent;

   private void Start()
   {
      label = GetComponent<Text>();
      startEvent.Invoke();
   }

   public void UpdateLable(IntData obj)
   {
      label.text = obj.value.ToString(CultureInfo.InvariantCulture);
   }
   public void UpdateLables()
   {
     label.text = scores.ToString();
   }
}
