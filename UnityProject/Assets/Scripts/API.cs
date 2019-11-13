using UnityEngine;

public class API : MonoBehaviour
{
    public Transform bird;

    private void Start()
    {
        Debug.Log("ya");
        Debug.LogWarning("warning!!!");
        Debug.LogError("NO");

        Debug.Log(Mathf.PI);

        Debug.Log(bird.position);
    }

}
