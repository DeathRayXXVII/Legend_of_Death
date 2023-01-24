using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
  public gameAction GameActionObj;
  private Image img;
  public UnityEvent startEvent;

  private void Start()
  {
    GameActionObj.raise  += RunStartEvent;
    img = GetComponent<Image>();
    startEvent.Invoke();
  }

  private void RunStartEvent()
  {
    startEvent.Invoke();
  }

  public void UpdateImage(floatData obj)
  {
    img.fillAmount = obj.value;
  }
}
