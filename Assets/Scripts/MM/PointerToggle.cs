using UnityEngine;

public class PointerToggle : MonoBehaviour
{
	public Animator leftPointer;
	public Animator rightPointer;

	private bool isSelected = false;

	public void ToggleSelection()
	{
		isSelected = !isSelected;

		if (isSelected)
		{
			PlayForward(leftPointer);
			PlayForward(rightPointer);
		}
		else
		{
			PlayBackward(leftPointer);
			PlayBackward(rightPointer);
		}
	}

	void PlayForward(Animator anim)
	{
		anim.speed = 1f;
		anim.Play("PointerAnim", 0, 0f); // start at beginning
	}

	void PlayBackward(Animator anim)
	{
		anim.speed = -1f;
		anim.Play("PointerAnim", 0, 1f); // start at the end
	}
}