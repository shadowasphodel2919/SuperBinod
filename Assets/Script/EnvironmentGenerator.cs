using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentGenerator : MonoBehaviour
{
    public Transform[] m_grass;
    public Transform[] m_bush;
    private void Awake()
    {
        GenerateGrass();
        GenerateBushes();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGrass()
    {
        int i = 0;
        while(i < 101)
        {
            int index = Random.RandomRange(0, 4);
            if(m_grass[index] == null)
            {
                continue;
            }
            float position = Random.Range(1.5f, 70f);
            if (position >= 8f && position <= 10f)
            {
                continue;
            }
            Vector3 v = new Vector3(position, y: -1f, 0);
            Transform grass;
            grass = Instantiate(m_grass[index], v, Quaternion.identity) as Transform;
            grass.name = "Grass";
            grass.transform.parent = transform;
            i++;
        }
    }

    void GenerateBushes()
    {
        int i = 0;
        while (i < 40)
        {
            int index = Random.RandomRange(0, 3);
            if (m_bush[index] == null)
            {
                continue;
            }
            float position = Random.Range(1.5f, 70f);
            if(position >= 8f && position <= 10f)
            {
                continue;
            }
            Vector3 v = new Vector3(position, y: -0.8f, 0);
            Transform bush;
            bush = Instantiate(m_bush[index], v, Quaternion.identity) as Transform;
            bush.name = "Bush";
            bush.transform.parent = transform;
            i++;
        }
    }
}
