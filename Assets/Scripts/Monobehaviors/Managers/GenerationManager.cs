using System;
using UnityEngine;

public class GenerationManager : Singleton<GenerationManager>
{
    [SerializeField] private GameObject generationPrefab;
    [SerializeField] private GameObjectTilemap tilemap;
    uint seedXYA, seedXYB, seedXYC,
         seedXZA, seedXZB, seedXZC,
         seedYXA, seedYXB, seedYXC,
         seedYZA, seedYZB, seedYZC,
         seedZXA, seedZXB, seedZXC,
         seedZYA, seedZYB, seedZYC;
    private bool initialized = false;

    public void Start()
    {
        Initialize();
    }

    public void BasicGenerate(int minX, int minY, int minZ,  int maxX, int maxY, int maxZ)
    {
        if ((!initialized))
        {
            Initialize();
        }
        for (int i = minX; i <= maxX; i++)
        {
            for(int j = minY; j <= maxY; j++)
            {
                for(int k = minZ; k <= maxZ; k++)
                {
                    float actualx = (i) / (float)int.MaxValue * 300000000;
                    float actualy = (j) / (float)int.MaxValue * 300000000;
                    float actualz = (k) / (float)int.MaxValue * 300000000;
                    GameObject go = Instantiate(generationPrefab);  
                    float color = PerlinGenerator.Noise3D(actualx, actualy, actualz, 
                        seedXYA, seedXYB, seedXYC, seedXZA, seedXZB, seedXZC, 
                        seedYXA, seedYXB, seedYXC, seedYZA, seedYZB, seedYZC, 
                        seedZXA, seedZXB, seedZXC, seedZYA, seedZYB, seedZYC);
                    go.GetComponent<MeshRenderer>().material.color = new Color(color, color, color);
                    tilemap.PlaceObjectAt(ref go, i, j, k);
                }
            }
        }
    }

    public void Initialize()
    {
        initialized = true;
        System.Random rand = new();
        seedXYA = (uint)rand.Next();
        seedXYB = (uint)rand.Next();
        seedXYC = (uint)rand.Next();
        seedXZA = (uint)rand.Next();
        seedXZB = (uint)rand.Next();
        seedXZC = (uint)rand.Next();
        seedYXA = (uint)rand.Next();
        seedYXB = (uint)rand.Next();
        seedYXC = (uint)rand.Next();
        seedYZA = (uint)rand.Next();
        seedYZB = (uint)rand.Next();
        seedYZC = (uint)rand.Next();
        seedZXA = (uint)rand.Next();
        seedZXB = (uint)rand.Next();
        seedZXC = (uint)rand.Next();
        seedZYA = (uint)rand.Next();
        seedZYB = (uint)rand.Next();
        seedZYC = (uint)rand.Next();
    }
}
