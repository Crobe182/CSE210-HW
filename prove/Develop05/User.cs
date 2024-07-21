using System.ComponentModel;
using System;

public class User
{
    private int _score;

    private int _longestEternalStreak;

    private int _goalsCompleted;

    private int _goalsInProgress;

    List<Goal> goalsAll;

    List<Goal> goalsInProgress;

    List<Goal> goalsCompleted;

    public User()
    {

    }

    public void setScore(int pointValue)
    {
        _score += pointValue;
    }

    public int getScore()
    {
        return _score;
    }

    public void appendList(List<Goal> listName, Goal goalTitle)
    {
        listName.Add(goalTitle);
    }

    public List<Goal> getGoalsAll()
    {
        return goalsAll;
    }

    public List<Goal> getGoalsInProgress()
    {
        return goalsInProgress;
    }

    public List<Goal> getGoalsCompleted()
    {
        return goalsCompleted;
    }

    public void setLongestEternalStreak()
    {

    }

    public int getLongestEternalStreak()
    {
        return _longestEternalStreak;
    }

    public void getUserInfo()
    {
        
    }
}