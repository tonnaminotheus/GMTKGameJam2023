using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimationController : MonoBehaviour
{
  Animator boxAnimator;

  void Start()
  {
    boxAnimator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
  }

  public void PressedBox()
  {
    boxAnimator.Play("Box_pressed");
  }

  public void RestartBox()
  {
    boxAnimator.Play("Box_idle");
  }

  public void GachaClick()
  {
    AudioManager.instance.Play("GachaClick");
  }

}
