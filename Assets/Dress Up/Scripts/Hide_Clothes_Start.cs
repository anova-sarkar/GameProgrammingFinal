using UnityEngine;

public class Hide_Clothes_Start : MonoBehaviour
{
    public GameObject[] Clothes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (GameObject obj in Clothes)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
