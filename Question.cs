using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question {

    private string q, a1, a2, a3;
    private int ra;
    public List<GameObject> paths;

    // Precondition: ans is either 1, 2, or 3.
    public Question(string question, string one, string two, string three, int ans)
    {
        q = question;
        a1 = one;
        a2 = two;
        a3 = three;
        ra = ans;
        paths = new List<GameObject>();
    }

    public string getQuestion()
    {
        return q;
    }

    public string getRightAnswer()
    {
        if (ra == 1)
            return a1;
        else if (ra == 2)
            return a2;
        else
            return a3;
    }

    public string getA1()
    {
        return a1;
    }

    public string getA2()
    {
        return a2;
    }

    public string getA3()
    {
        return a3;
    }

    public GameObject getPath(int i)
    {
        return this.paths[i-1];
    }

    public void addPaths(GameObject one, GameObject two, GameObject three)
    {
        this.paths.Clear();
        this.paths.Add(one);
        this.paths.Add(two);
        this.paths.Add(three);
    }

    public string getAnswer(int i)
    {
        if (i == 1)
            return a1;
        if (i == 2)
            return a2;
        else
            return a3;
    }
}