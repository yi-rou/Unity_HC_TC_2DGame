using UnityEngine;

public class API : MonoBehaviour
{
    public Transform bird;

    private void Start()
    {
        Debug.Log("ya");
        Debug.LogWarning("warning!!!");
        Debug.LogError("NO");

        Debug.Log(Random.value);
        Debug.Log(Mathf.PI);
        Debug.Log(Random.Range(1,33));
        Debug.Log(bird.position);
    }

}
