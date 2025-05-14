using UnityEngine;

public class Add_Remove : MonoBehaviour
{

    public GameObject[] SameType;
    public GameObject TargetPiece;
    public ParticleSystem PS;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (TargetPiece.activeSelf == false)
        {
            //Hides clothing pieces of the same type as target
            foreach (GameObject obj in SameType)
            {
                obj.SetActive(false);
            }
            //Then places target piece on Melia
            TargetPiece.SetActive(true);
            PS.Emit(5);
        } else
        {
            //Remove target piece if it is already on Melia
            TargetPiece.SetActive(false);
        }
    }
}
