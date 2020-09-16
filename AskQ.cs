using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AskQ : MonoBehaviour {

    private static List<Question> list = new List<Question>();
    public GameObject qp;   // QuestionPlatform - canvas upon which maze questions are displayed

    // A list of all the questions the player can be asked in the maze.
    private static Question[] questions = {
        new Question("Who proposed the concept of FBLA?", "Dave Strider",
            "Hamden L. Forkner", "Jean Buckley", 2),
        new Question("Who is the CEO of FBLA?", "Alexander Graham", "Hamden L. Forkner",
            "Jean Buckley", 1),
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
            "Incidental", "Subsidiary", 1),
        new Question("Finish this goal of FBLA: \"encourage members in the development of individual projects which" +
            "contribute to the improvement of _________________\"", "Home, school, and society",
            "Home, business, and community", "School, business, and society", 2),
        new Question("The national dues were raised from $5 to $6 in 1994.", "True", "False", "", 1),
        new Question("The FBLA Marketplace provides blazers, jewelry, trophies, and chapter management tools.",
            "True", "False", "", 1),
        new Question("The FBLA fiscal year is September 6th - June 25th.", "True", "False", "", 2),
        new Question("Your local chapter is recognized for the gold seal award at the State Leadership Conference.",
            "True", "False", "", 2),
        new Question("Two members from each state can receive the Who's Who award if there is a national officer " +
            "from that state.", "True", "False", "", 1),
        new Question("FBLA has a close national partnership with March of Dimes.", "True", "False", "", 1)
 };

    public Transform r, o, y, g, b;     // Teleportation destinations

    private static List<GameObject> walls = new List<GameObject>();

    public GameObject[] btn2, btn3;

    public GameObject ScriptHolder;

    private void Start()
    {
        init();
        qp.SetActive(false);
    }

    private void init()
    {
        list.Clear();
        list.AddRange(questions);
    }

    // Store the right answer in an external object to reference later.
    private void writeAnswerToText(string ra)
    {
        ScriptHolder.GetComponent<Text>().text = ra;
    }

    // Retrieve the right answer from an external object.
    private string getText()
    {
        return ScriptHolder.GetComponent<Text>().text;
    }

    // Method called when player interacts with a "?" wall.
    private void OnTriggerEnter(Collider other)
    {
        int rand = Random.Range(0, list.Count);
        Question qs = list[rand];
        qp.SetActive(true);
        Debug.Log(qp);
        TextMeshProUGUI q = qp.GetComponentInChildren<TextMeshProUGUI>();
        q.text = qs.getQuestion();
        string ra = qs.getRightAnswer();
        int i = 1;

        writeAnswerToText(ra);

        // Two sets of buttons for questions with either two or three options.
        if (qs.getA3().Equals(""))
        {
            foreach (GameObject btn in btn3)
                btn.SetActive(false);

            foreach (GameObject btn in btn2)
            {
                btn.SetActive(true);
                Text txt = btn.GetComponentInChildren<Text>();
                txt.text = qs.getAnswer(i);
                i++;
            }
        } else
        {
            foreach (GameObject btn in btn2)
            {
                btn.SetActive(false);
            }

            foreach (GameObject btn in btn3)
            {
                btn.SetActive(true);
                Text txt = btn.GetComponentInChildren<Text>();
                txt.text = qs.getAnswer(i);
                i++;
            }
        }

        // Change tag to a special "found" tag so it can be found later.
        gameObject.tag = detTag(gameObject.tag);

        qp.SetActive(true);
        Debug.Log(qp.activeInHierarchy);

        list.RemoveAt(rand);

        if (list.Count == 0)
            init();
    }

    // exit function for the maze introduction
    public void exit()
    {
        qp.SetActive(false);
    }

    // Determine found tag using an integer (from context of a loop).
    private string detTag(int x)
    {
        if (x == 1)
            return "ared";
        else if (x == 2)
            return "aorange";
        else if (x == 3)
            return "ayellow";
        else if (x == 4)
            return "agreen";
        else if (x == 5)
            return "ablue";
        else if (x == 6)
            return "apurple";
        else if (x == 7)
            return "apink";
        return "";
    }

    // Determine found tag using previous tag.
    private string detTag(string tag)
    {
        if (tag.Equals("red"))
            return "ared";
        else if (tag.Equals("orange"))
            return "aorange";
        else if (tag.Equals("yellow"))
            return "ayellow";
        else if (tag.Equals("green"))
            return "agreen";
        else if (tag.Equals("blue"))
            return "ablue";
        else if (tag.Equals("purple"))
            return "apurple";
        else if (tag.Equals("pink"))
            return "apink";
        return "";
    }

    // Return tag to normal.
    private string retTag(string tag)
    {
        if (tag.Equals("ared"))
            return "red";
        else if (tag.Equals("aorange"))
            return "orange";
        else if (tag.Equals("ayellow"))
            return "yellow";
        else if (tag.Equals("agreen"))
            return "green";
        else if (tag.Equals("ablue"))
            return "blue";
        else if (tag.Equals("apurple"))
            return "purple";
        else if (tag.Equals("apink"))
            return "pink";
        return tag;
    }

    // Method called when a button is pressed on the UI.
    public void btnClick(Button btn)
    {
        Text txt = btn.GetComponentInChildren<Text>();
        GameObject wall;
        int x = 1;
        string tag;
        do
        {
            tag = detTag(x);
            wall = GameObject.FindGameObjectWithTag(tag);
            x++;

        } while (wall == null && x < 8);
        
        if (txt.text.Equals(getText()))
        {
            wall.SetActive(false);
            walls.Add(wall);
            wall.tag = retTag(wall.tag);
        } else
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if (wall.tag.Equals("ared") || wall.tag.Equals("aorange") || wall.tag.Equals("ayellow"))
            {
                // teleport to beginning of red zone
                player.transform.position = r.transform.position;
            } else if (wall.tag.Equals("agreen"))
            {
                // teleport to orange
                player.transform.position = o.transform.position;
            } else if (wall.tag.Equals("ablue"))
            {
                // teleport to yellow
                player.transform.position = y.transform.position;
            } else if (wall.tag.Equals("apurple"))
            {
                // teleport to green
                player.transform.position = g.transform.position;
            } else
            {
                // teleport to blue
                player.transform.position = b.transform.position;
            }
            wall.tag = retTag(wall.tag);
            resetDoors();
        }

        qp.SetActive(false);
    }

    private void resetDoors()
    {

        foreach (GameObject g in walls)
        {
            g.SetActive(true);
        }
    }
}
