using UnityEngine;

public class openTutorialTunnel : MonoBehaviour {
    public GameObject tutorialSparkLeft;
    public GameObject tutorialSparkRight;
    public GameObject tutorialSparkRear;
    public Material part5Mat;
    public GameObject tutorialTunnelPart5;
    void Start()
    {
        part5Mat.SetFloat("_Metallic", 1);
    }
    // Update is called once per frame
    void Update () {
		if(tutorialSparkLeft.activeSelf == false && tutorialSparkRight.activeSelf == false && tutorialSparkRear.activeSelf == false)
        {
            part5Mat.SetFloat("_Metallic", part5Mat.GetFloat("_Metallic") - 0.01f);
            if(part5Mat.GetFloat("_Metallic") <= 0)
            {
                tutorialTunnelPart5.SetActive(false);
            }
        }
	}
}
