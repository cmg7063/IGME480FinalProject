using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : MonoBehaviour
{
    public GameObject player;

    public Vector3[] pathPoints;
    public int currIndex; //current target
    public float posMargin = 1.05f; //margin of error to switch to next target
    public bool isMoving; //set to false when blurb pops up, set to true when user closes blurb
    public float maxDistToPlayer; //max distance the guide can be from the player
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        pathPoints = new Vector3[] {
        new Vector3(43.08665663569291f, 0, -77.66828682742374f),
     new Vector3(43.08649502832579f, 0,-77.66815808139103f),
     new Vector3(43.08627073618251f, 0, -77.66815942249553f),
     new Vector3(43.08630501669426f, 0, -77.66839679799335f),
     new Vector3(43.08625604452876f, 0, -77.66849872193592f),
     new Vector3(43.086276612843044f, 0, -77.66862612686413f),
     new Vector3(43.086171812312486f, 0, -77.66870659313457f),
     new Vector3(43.08614174259208f, 0, -77.66878689088969f),
     new Vector3(43.08613292758169f, 0, -77.66920397439151f),
     new Vector3(43.08541498969877f, 0, -77.66919995107799f),
    new Vector3(43.08544731177619f, 0, -77.66742432871013f),
    new Vector3(43.085442414493336f, 0, -77.66771803059726f),
    new Vector3(43.08513682323736f, 0, -77.66775692262797f),
    new Vector3(43.08492330023726f, 0, -77.66788030424266f),
     new Vector3(43.08490273146858f, 0, -77.66803050794749f),
     new Vector3(43.084845922452544f, 0, -77.66804257788806f),
     new Vector3(43.0847861749823f, 0, -77.66816595950274f),
     new Vector3(43.0846872487149f, 0, -77.66823167362361f),
    new Vector3(43.08453445139402f, 0, -77.66823837914615f),
     new Vector3(43.08436304368972f, 0, -77.66834030308871f),
     new Vector3(43.08435912579371f, 0, -77.66911680259852f),
      new Vector3(43.08396341700727f, 0, -77.66916240015178f),
      new Vector3(43.08435814631981f, 0, -77.66924286642222f),
      new Vector3(43.0843326799894f, 0, -77.67019102730899f),
      new Vector3(43.084305254698734f, 0, -77.67167697110324f),
      new Vector3(43.08428370624731f, 0, -77.67257551112323f),
      new Vector3(43.084269014116984f, 0, -77.67347271003871f),
      new Vector3(43.08426411673945f, 0, -77.67383883156924f),
      new Vector3(43.084269993592464f, 0, -77.67411509909778f),
      new Vector3(43.08428566519776f, 0, -77.67427871384768f),
      new Vector3(43.084276849920265f, 0, -77.67445842185168f),
      new Vector3(43.08427195254334f, 0, -77.6748580709949f),
      new Vector3(43.084255301458846f, 0, -77.67541597047f),
      new Vector3(43.08430721364849f, 0, -77.67557287969737f),
      new Vector3(43.08439928421626f, 0, -77.67558226742892f),
      new Vector3(43.08441397631531f, 0, -77.67598325767665f),
      new Vector3(43.08453934875077f, 0, -77.67600069203525f),
      new Vector3(43.08466667986809f, 0, -77.67590949692874f),
      new Vector3(43.08482437419245f, 0, -77.67600739755778f),
      new Vector3(43.08495562257535f, 0, -77.67609054603724f),
      new Vector3(43.084904690400485f, 0, -77.67629037060885f),
      new Vector3(43.084806743791574f, 0, -77.6764781252399f),
      new Vector3(43.084624562682066f, 0, -77.67656395592837f),
      new Vector3(43.08453738980916f, 0, -77.67677450933604f),
      new Vector3(43.08437577685151f, 0, -77.67697969832568f),
      new Vector3(43.084219060848675f, 0, -77.67679730811267f),
      new Vector3(43.08424256827466f, 0, -77.67623404421954f),
      new Vector3(43.084252363032945f, 0, -77.67602617302089f),
      new Vector3(43.0842553014601f, 0, -77.6755782441154f),
      new Vector3(43.08425040408144f, 0, -77.6754334048286f),
      new Vector3(43.084168128061556f, 0, -77.67546290912776f),
      new Vector3(43.083935991552856f, 0, -77.67568150916247f),
      new Vector3(43.08382628960546f, 0, -77.6757579521194f),
      new Vector3(43.083676428592184f, 0,-77.67576733985095f),
      new Vector3(43.083641167123965f, 0,-77.67536500849872f),
      new Vector3(43.083522649262584f, 0,-77.67503241458087f),
      new Vector3(43.08328855132564f, 0,-77.67501632132678f),
      new Vector3(43.08327189997393f,0, -77.6753435508266f),
      new Vector3(43.08326700251669f,0, -77.67606640615611f),
      new Vector3(43.083249371667264f,0, -77.67687106886058f),
      new Vector3(43.08322978182867f, 0,-77.6775966063991f),
      new Vector3(43.08327875641366f, 0,-77.67850185194163f),
      new Vector3(43.08350305951176f, 0,-77.67829934516101f),
    new Vector3(43.08374597198429f, 0,-77.67816925802379f),
     new Vector3(43.083910525047756f, 0,-77.67817328133731f),
     new Vector3(43.08389093542058f, 0,-77.67893771090655f),
     new Vector3(43.08389289438357f, 0,-77.67938698091655f),
     new Vector3(43.08349816207338f, 0,-77.67938429870753f),
    new Vector3(43.083295407764204f, 0,-77.67938295760302f),
     new Vector3(43.08334732076731f, 0,-77.67895648636966f),
     new Vector3(43.083285612853096f,0, -77.67852465071826f),
     new Vector3(43.08314848393236f, 0,-77.67861852803378f),
     new Vector3(43.08301429319144f, 0,-77.67889077224879f),
     new Vector3(43.083016252182475f,0, -77.6791791097179f),
    new Vector3(43.08306032946417f, 0,-77.67938832202105f),
     new Vector3(43.082970215876614f,0, -77.67956132450252f),
     new Vector3(43.082943769472486f,0, -77.67993012824206f),
     new Vector3(43.08293103601457f, 0,-77.68025601663737f),
    new Vector3(43.0829535644383f, 0,-77.68061409154086f),
     new Vector3(43.08293005651772f, 0,-77.6808554903522f)
    };
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPos = player.GetComponent<GpsTracking>().GetPosition();
        Vector3 goal = pathPoints[currIndex];
        print(currIndex);

        print((goal - currPos).magnitude);

        if ((goal - currPos).magnitude < posMargin)
        {
            currIndex++;
            if (currIndex >= pathPoints.Length)
            {
                //End the tour!!!!
                currIndex = 0;
            }
            arrow.GetComponent<ArrowDirection>().UpdateTarget(pathPoints[currIndex]);
        }
        
    }
}
