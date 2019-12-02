using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;
public class ThrottleOPView : Singleton<ThrottleOPView>
{
    private int nodeLevel;
    [SerializeField] private Image[] nodeImages;
    [SerializeField] private Color32[] nodeColors;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    

    public void SetNodeLevel(int nodeLevel){
        this.nodeLevel = nodeLevel;

        Debug.Log("Node level: " + nodeLevel);
        ActiveNodeImage();

    }

    void ActiveNodeImage(){
        for (int i = 0; i < nodeImages.Length; i++)
        {
            nodeImages[i].color = nodeColors[0];
        }

        nodeImages[IntNodeToNodeImageOrder()].color = nodeColors[1];
    }

    private int IntNodeToNodeImageOrder(){
        switch (nodeLevel)
        {
            case 0: 
                return 4;
            case 1: 
                return 3;
            case 2: 
                return 2;
            case 3: 
                return 1;
            case 4: 
                return 0;
            case -1: 
                return 5;
            case -2: 
                return 6;
            case -3: 
                return 7;
            case -4: 
                return 8;
            case -5: 
                return 9;
            default:
                return 4;
        }
    }

    private string IntNodeToStringNode(){
        switch (nodeLevel)
        {
            case 0: 
                return "N";
            case 1: 
                return "P1";
            case 2: 
                return "P2";
            case 3: 
                return "P3";
            case 4: 
                return "P4";
            case -1: 
                return "B1";
            case -2: 
                return "B2";
            case -3: 
                return "B3";
            case -4: 
                return "B6";
            case -5: 
                return "EM";
            default:
                return "N";
        }
    }
}
