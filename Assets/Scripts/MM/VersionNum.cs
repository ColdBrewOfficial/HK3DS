using UnityEngine;

public class VersionNum : MonoBehaviour
{
	void Start()
	{

		TextMesh mesh = GetComponent<TextMesh>();
		if(mesh != null)
		{
			mesh.text = "Version " + Application.version + " (3DS)";
		}
	}
}