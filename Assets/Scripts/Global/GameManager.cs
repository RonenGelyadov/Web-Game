using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager { get; private set; }

    void Awake()
    {
        if (manager == null)
        {
			manager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

	void Update()
	{
		
	}
}
