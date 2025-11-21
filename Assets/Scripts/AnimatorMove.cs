using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorMove : MonoBehaviour
{
	public InputActionAsset seePlayerAction;
	public Animator seeAnimator;

	void Update()
	{
		if (seePlayerAction.FindAction("Move").IsPressed())
		{
			seeAnimator.SetBool("moving", true);
		}
		else
		{
			seeAnimator.SetBool("moving", false);
		}
	}
    
}
