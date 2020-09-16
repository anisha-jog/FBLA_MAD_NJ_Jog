using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionRandomizer : MonoBehaviour {

    List<Question> qs = new List<Question>();
    List<Question> tmp = new List<Question>();

    // All questions
    private static Question[] questions = {
        new Question("Who proposed the concept of FBLA?", "Dave Strider",
            "Hamden L. Forkner", "Jean Buckley", 2), 
        new Question("Who is the CEO of FBLA?", "Jean Buckley", "Hamden L. Forkner",
            "Sarah Murphy", 1),
        new Question("Who is the National PBL President?", "Peter Choi", "Jade Harley",
            "Karthik Krishnan", 3),
        new Question("Who is the membership director?", "Peter Choi", "Lisa Frye Smothers", "Vanessa Ting", 2),
        new Question("Who is the IL PBL Vice President of Communications?", "Jean Buckley",
            "Karthik Krishnan", "Mary Kate Herman", 3),
        new Question("Who is the National PBL Treasurer?", "Peter Choi", "Vanessa Ting", "Lisa Frye Smothers", 1),
        new Question("Who is the National FBLA Parliamentarian?", "Karthik Krishnan", "Vanessa Ting", "John Egbert", 2),
        new Question("What are the FBLA colors?", "Red and Black", "Green and Violet",
            "Blue and Gold", 3),
        new Question("Where are the FBLA headquarters?", "Cincinnati, Ohio", "Reston, Virginia",
            "Cedar Falls, Iowa", 2),
        new Question("What is the national FBLA publication?", "Tomorrow's Business Leader",
            "Spotlight", "Professional Edge", 1),
        new Question("What is the national PBL publication?", "Tomorrow's Business Leader",
            "Spotlight", "Professional Edge", 3),
        new Question("What is the name of the book with set rules and bylaws for FBLA?",
            "Robert's Rules of Order", "Chapter Management Handbook", "FBLA-PBL Bylaws", 1),
        new Question("Which article in the FBLA bylaws is about membership?", "Article III",
            "Article I", "Article II", 1),
        new Question("What 3 words are on our emblem?", "Patience, Progress, Professionalism",
            "Service, Education, Progress", "Business, Education, Professionalism", 2),
        new Question("In what state was the first PBL chapter created?", "Tennessee",
            "New York", "Iowa", 3),
        new Question("When was the first chapter chartered?", "February 3rd, 1942", "March 31st, 1968", "November 22nd, 1931", 1),
        new Question("Where was the first chapter chartered?", "University of Northern Iowa",
            "Columbia University", "University of Virginia", 1),
        new Question("When is FBLA-PBL week?", "2nd week of February", "1st week of February", "Last week of March", 1),
        new Question("Who appoints the President and CEO of FBLA-PBL?", "Board of Directors",
            "All FBLA members", "Former FBLA President and CEO", 1),
        new Question("What is the national annual summer event that prepares student leaders?",
            "National Leadership Conference", "FBLA Leadership Summer Education", "Institute for Leaders", 3),
        new Question("What does NBEA stand for?", "National Board of Education and Achievement",
            "National Business Education Association", "Natural Business Education of America", 2),
        new Question("How many times a year does the Board of Directors meet?", "At least twice",
            "Once every two months", "At least once", 1),
        new Question("How long is the term for a member of the Board of Directors?", "3 years",
            "1 year", "2 years", 1),
        new Question("Which two members need to be present in order for a formal business meeting to take place?",
            "President and Secretary", "Chair and Secretary", "President and Vice President", 2),
        new Question("What does MAP stand for?", "Measures of Applicable Progress",
            "Middle-Level Achievement Program", "Minimum Available Persons", 2),
        new Question("What is the guide for advisors and officers which " +
            "provides basic guidelines and tools for chapter growth and program development?",
            "Robert's Rules of Order", "FBLA-PBL Bylaws", "Chapter Management Handbook", 3),
        new Question("What are the 3 levels of community service?", "Home, Business, Service Achievements",
            "Home, Community, Business", "Community, Service, Achievement", 3),
        new Question("What are the 3 Middle Level dues?", "District: $2 State: $4 National: $4",
            "District: $3 State: $3 National: $4", "District: $2 State: $4 National: $6", 1),
        new Question("What are the 3 High School dues?", "District: $2 State: $4 National: $4",
            "District: $2 State: $4 National: $6", "District: $4 State: $3 National: $6", 2),
        new Question("How many hours do you need to complete the service level of the community service awards?",
            "200", "100", "30", 1),
        new Question("Competitive events fall into which three categories?", "Individual, Team, Chapter",
            "Regional, State, National", "Test, Project, Presentation", 1),
        new Question("Which award honors FBLA members who have made outstanding contributions at " + 
            "the local, state, and national levels?", "Who’s Who", "7-Up", "FBLA Outstanding Chapter Award", 1),
        new Question("What grades is the Middle Level open to?", "7-10", "5-9", "6-8", 2),
        new Question("What color candle is used to install a treasurer into the officer team?",
            "Yellow", "Orange", "Blue", 3),
        new Question("What officer position is the yellow candle used to install?", "Treasurer",
            "Chair", "Secretary", 3),
        new Question("What are the 3 levels of the Career and Membership Achievement Program?",
            "Manager, Vice President, President", "Member, Director, Executive", "Director, Executive, President", 3),
        new Question("What is the membership year of FBLA?", "August 1st - July 31st",
            "September 1st - June 25th", "October 1st - July 1st", 1),
        new Question("What ribbon does a local chapter receive at NLC for recruiting 7 more members " +
            "than last year?", "Membership Achievement Award", "7-Up", "Who's Who", 2),
        new Question("What category of competition does the American Enterprise Project fall under?",
            "Chapter", "Team", "Individual", 1),
        new Question("What name is given to the members who elect the national vice president at the NLC?",
            "Local Voting Delegates", "National Representatives", "State Voting Members", 1),
        new Question("What is the parliamentary term of motion to secure an immediate vote on one " +
            "or more pending questions thereby ending debate?", "Previous Question",
            "Lay on the Table", "Commit or Refer", 1),
        new Question("What is the parliamentary term to delay a motion and clear the floor for more " +
            "urgent business?", "Commit or Refer", "Call for Orders of the Day", "Lay on the Table", 3),
        new Question("What is the parliamentary term used when someone has led the discussion away " +
            "from the motion or agenda order?", "Point of Order", "Call for Orders of the Day", "Previous Question", 2),
        new Question("What is the parliamentary term that calls attention to violation of " +
            "parliamentary procedure?", "Point of Order", "Previous Question", "Call for Orders of the Day", 1),
        new Question("Which set of motions rank highest in parliamentary procedures?", "Privileged",
            "Incidental", "Subsidiary", 1)
 };

    // All text objects
    public List<TextMeshPro> qtxt = new List<TextMeshPro>();
    public List<TextMeshPro> a1txt = new List<TextMeshPro>();
    public List<TextMeshPro> a2txt = new List<TextMeshPro>();
    public List<TextMeshPro> a3txt = new List<TextMeshPro>();
    public List<GameObject> door = new List<GameObject>();

    int rand, i;

    // Use this for initialization
    void Start () {
        initList();

        randomize();

        addDoors();

        addKill();
    }

    void initList()
    {
        // for loop to randomize qs and assign them to text objects
        qs.Clear();
        tmp.Clear();
        foreach (Question q in questions)
        {
            qs.Add(q);
        }
    }

    void randomize()
    {
        for (i = 0; i < qtxt.Count; i++)
        {
            rand = Random.Range(0, qs.Count);
            qtxt[i].text = qs[rand].getQuestion();
            a1txt[i].text = qs[rand].getA1();
            a2txt[i].text = qs[rand].getA2();
            a3txt[i].text = qs[rand].getA3();
            tmp.Add(qs[rand]);
            qs.RemoveAt(rand);
        }
    }

    void addDoors()
    {
        int j = 0;

        // Add doors to each question
        for (i = 0; i < tmp.Count && j < door.Count - 2; i++)
        {
            tmp[i].addPaths(door[j], door[j + 1], door[j + 2]);
            j += 3;
        }
    }

    void addKill()
    {
        // Add GameOver scripts to wrong answers
        for (i = 0; i < a1txt.Count; i++)
        {
            if (tmp[i].getPath(1) == null)
            {
                Debug.Log("i: " + i + " :is null");
            }
            else
            {
                if (!tmp[i].getA1().Equals(tmp[i].getRightAnswer()))                // If A1 is not correct
                {

                    if (tmp[i].getPath(1).tag.Equals("teleporter"))                 // If it's a tp pad, destroy its teleporter
                        Destroy(tmp[i].getPath(1).GetComponent<Teleporter>());
                    else if (tmp[i].getPath(1).tag.Equals("dangerous-paths"))             // If A1 is correct and it's a self-destruct
                    {
                        tmp[i].getPath(1).AddComponent<SelfDestruct>();
                    }
                    else
                        tmp[i].getPath(1).AddComponent<KillScript>();               // Else, add a killscript to the object.
                }
                else if (tmp[i].getPath(1).tag.Equals("self-destruct"))             // If A1 is correct and it's a self-destruct
                {
                    tmp[i].getPath(1).AddComponent<SelfDestruct>();
                }
                else if (tmp[i].getPath(1).tag.Equals("dangerous-paths"))             // If A1 is correct and it's a self-destruct
                {
                    tmp[i].getPath(1).GetComponent<BoxCollider>().isTrigger = false;
                }
                else if (tmp[i].getPath(1).tag.Equals("teleporter"))                // If A1 is correct and it's a tp, destroy its killscript
                {
                    Destroy(tmp[i].getPath(1).GetComponent<KillScript>());
                }

                if (!tmp[i].getA2().Equals(tmp[i].getRightAnswer()))                // A2
                {
                    if (tmp[i].getPath(2).tag.Equals("teleporter"))
                        Destroy(tmp[i].getPath(2).GetComponent<Teleporter>());
                    else if (tmp[i].getPath(2).tag.Equals("dangerous-paths"))
                    {
                        tmp[i].getPath(2).AddComponent<SelfDestruct>();
                    }
                    else
                        tmp[i].getPath(2).AddComponent<KillScript>();
                }
                else if (tmp[i].getPath(2).tag.Equals("self-destruct"))
                {
                    tmp[i].getPath(2).AddComponent<SelfDestruct>();
                }
                else if (tmp[i].getPath(2).tag.Equals("dangerous-paths"))             // If A1 is correct and it's a self-destruct
                {
                    tmp[i].getPath(2).GetComponent<BoxCollider>().isTrigger = false;
                }
                else if (tmp[i].getPath(2).tag.Equals("teleporter"))
                {
                    Destroy(tmp[i].getPath(2).GetComponent<KillScript>());
                }

                if (!tmp[i].getA3().Equals(tmp[i].getRightAnswer()))               // A3
                {
                    if (tmp[i].getPath(3).tag.Equals("teleporter"))
                        Destroy(tmp[i].getPath(3).GetComponent<Teleporter>());
                    else if (tmp[i].getPath(3).tag.Equals("dangerous-paths"))
                    {
                        tmp[i].getPath(3).AddComponent<SelfDestruct>();
                    }
                    else
                        tmp[i].getPath(3).AddComponent<KillScript>();
                }
                else if (tmp[i].getPath(3).tag.Equals("self-destruct"))
                {
                    tmp[i].getPath(3).AddComponent<SelfDestruct>();
                }
                else if (tmp[i].getPath(3).tag.Equals("dangerous-paths"))             // If A1 is correct and it's a self-destruct
                {
                    tmp[i].getPath(3).GetComponent<BoxCollider>().isTrigger = false;
                }
                else if (tmp[i].getPath(3).tag.Equals("teleporter"))
                {
                    Destroy(tmp[i].getPath(3).GetComponent<KillScript>());
                }
            }
        }
    }
}
