using UnityEngine;

public class Audio : MonoBehaviour
{
	public AudioSource music;

	void Start()
	{
		Invoke("PlayMusic", 8.5f);
	}

	void PlayMusic()
	{
		music.Play();
	}
}