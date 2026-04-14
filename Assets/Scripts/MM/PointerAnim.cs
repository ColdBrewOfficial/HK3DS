using UnityEngine;
using UnityEngine.SceneManagement;

public class PointerAnim : MonoBehaviour
{
	public Animator leftPointer;
	public Animator rightPointer;

	bool clicked = false;

	void OnMouseDown()
	{
		if (!clicked)
		{
			clicked = true;

			leftPointer.speed = 1;
			rightPointer.speed = 1;

			leftPointer.Play("PointerAnim", 0, 1f);
			rightPointer.Play("PointerAnim", 0, 1f);

			Invoke("LoadNextScene", 0.2f);
		}
	}

	void LoadNextScene()
	{
		SceneManager.LoadScene("NextScene");
	}
}