using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects_Managements : MonoBehaviour
{
    public GameObject[] objects;
    int currentIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentIndex++;
            if (currentIndex >= objects.Length)
            {
                currentIndex = 0;
            }
            DeactivateAll();
            ActivateByIndex(currentIndex);
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
    }
    void ActivateByIndex(int index)
    {
        objects[index].SetActive(true);
    }
}