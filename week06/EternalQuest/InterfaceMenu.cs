using System.IO;

public class InterfaceMenu
{

    private int _points = 0;

    private int _choice;

    private List<Goal> goalTracker = new List<Goal>();

    public void PointsRecorder()
    {
        string filePath = Path.Combine("..", "..", "..", "RecordPoints.txt");
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            writer.WriteLine(_points);
        }
    }

    public void getPoints()
    {
        string filePath = Path.Combine("..", "..", "..", "RecordPoints.txt");
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            _points = int.Parse(line);
        }
    }

    public bool determineIfGoalsTxtFileIsEmpty()
    {
        string filePath = Path.Combine("..", "..", "..", "Goals.txt");
        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length == 0)
        {
            return true;
        }

        return false;
    }

    public void Menu()
    {
      
        Console.WriteLine($"You have {_points} points");
        Console.Write($@"
        Menu Options: 
            1. Create New Goal
            2. Lists Goals
            3. Save Goals
            4. Load Goals
            5. Record Events
            6. Quit
        Select a choice from the menu: ");
        
        _choice = int.Parse(Console.ReadLine());
    }

    public int choice()
    {
        return _choice;
    }

    public void chosenItem(int menuNumber)
    {
        if (menuNumber == 1)
        {

            Console.WriteLine("The types of goals are: ");
            Console.WriteLine($@"
                1. Simple Goal
                2. Eternal Goal
                3. Checklist Goal
                ");
            Console.Write("Which type of goal would you like to create? ");
            try
            {
                int typeChoice = int.Parse(Console.ReadLine());
                GoalTypePicked(typeChoice);

            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            


        }
        else if (menuNumber == 2)
        {
            Console.WriteLine("The goals are: ");
            DisplayListOfGoals();
        }
        else if (menuNumber == 3)
        {
            Console.WriteLine("Saving Goals...");
            SaveGoals();
        }
        else if (menuNumber == 4)
        {
            Console.WriteLine("Loading Goals...");
            LoadGoals();
        }
        else if (menuNumber == 5)
        {
            Console.WriteLine("Recording Events");
            if (goalTracker.Count == 0)
            {
                Console.WriteLine("You don't have any goals listed");
            }
            else
            {
                RecordEvents();
            }
            
        }
    }

    public void Test()
    {
        string filePath = Path.Combine("..", "..", "..", "Goals.txt");
        string[] lines = File.ReadAllLines(filePath);

        foreach(string line in lines){
            string[] parts = line.Split('|');
            string part3 = parts[3].Replace("Points", "").Trim();
            Console.WriteLine(parts[2].Trim());
            // Console.WriteLine($"{parts[0]}{parts[1]}{parts[2]}{int.Parse(part3)}");
        }
    }

public void LoadGoals()
{
    string filePath = Path.Combine("..", "..", "..", "Goals.txt");
    string filePathForCheckList = Path.Combine("..", "..", "..", "ChecklistGoals.txt");

    if (File.Exists(filePathForCheckList))
    {
        string[] checklistLines = File.ReadAllLines(filePathForCheckList);
        foreach (string line in checklistLines)
        {
            string[] parts = line.Split('|');
            string pointsPart = parts[3].Replace("Points", "").Trim();
            string repsPart = parts[4].Replace("Reps Left:", "").Trim();

            ChecklistGoalPicked(parts[1].Trim(), parts[2].Trim(), int.Parse(pointsPart), int.Parse(repsPart));
        }
    }

    if (File.Exists(filePath))
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string goalType = parts[0].Trim();
            string goalName = parts[1].Trim();
            string description = parts[2].Trim();
            string pointsPart = parts[3].Replace("Points", "").Trim();
            int points = int.Parse(pointsPart);

            if (goalType == "Simple Goal")
            {
                SimpleGoalPicked(goalName, description, points);
            }
            else if (goalType == "Eternal Goal")
            {
                EternalGoalPicked(goalName, description, points);
            }
        }
    }
}


    public void ClearGoals()
    {
        string filePath = Path.Combine("..", "..", "..", "Goals.txt");
        File.WriteAllText(filePath, string.Empty);

    }

    public void SaveGoals()
    {
        string filePath = Path.Combine("..", "..", "..", "Goals.txt");

        string filePathForCheckList = Path.Combine("..", "..", "..", "ChecklistGoals.txt");


        // using (StreamWriter writer = new StreamWriter(filePath, false))
        // {
        //     foreach (Goal g in goalTracker)
        //     {
        //         writer.WriteLine($"{g.getSummaryOfGoal()}");
        //     }
        // }

        foreach (Goal g in goalTracker)
        {
            if (g.getType() == "Checklist Goal")
            {
                using (StreamWriter writer = new StreamWriter(filePathForCheckList, false))
                {
                    writer.WriteLine($"{g.getSummaryOfGoal()}|{g.getTimesToComplete()} Reps Left");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine($"{g.getSummaryOfGoal()}");
                }
            }
        }
    }
    public void SaveGoalsWhenRecordHasBeenUpdated()
    {
        string filePath = Path.Combine("..", "..", "..", "Goals.txt");
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach (Goal g in goalTracker)
            {
                writer.WriteLine($"{g.getSummaryOfGoal()}");
            }
        }
    }
    public void GoalTypePicked(int choice)
    {

        Console.WriteLine("What is the name of your goal: ");
        string NameOfGoal = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal: ");
        string DescriptionOfGoal = Console.ReadLine();
        Console.WriteLine("What is the associated amount of point for this goal: ");
        int PointsOfGoal = int.Parse(Console.ReadLine());




        if (choice == 1)
        {
            SimpleGoalPicked(NameOfGoal, DescriptionOfGoal, PointsOfGoal);
        }
        else if (choice == 2)
        {
            EternalGoalPicked(NameOfGoal, DescriptionOfGoal, PointsOfGoal);
        }
        else if (choice == 3)
        {
            Console.Write("How many times: ");
            int times = int.Parse(Console.ReadLine());
            ChecklistGoalPicked(NameOfGoal, DescriptionOfGoal, PointsOfGoal, times);
        }
    }

    public void SimpleGoalPicked(string goalName, string sDescription, int goalPoints)
    {
        SimpleGoal newSimpleGoal = new SimpleGoal(goalName, sDescription, goalPoints);
        goalTracker.Add(newSimpleGoal);
    }
    public void EternalGoalPicked(string goalName, string sDescription, int goalPoints)
    {
        EternalGoal newEternalGoal = new EternalGoal(goalName, sDescription, goalPoints);
        goalTracker.Add(newEternalGoal);
    }
    public void ChecklistGoalPicked(string goalName, string sDescription, int goalPoints, int times)
    {
        ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, sDescription, goalPoints, times);
        goalTracker.Add(newChecklistGoal);  
    }

    public void DisplayListOfGoals()
    {
        if (goalTracker.Count == 0)
        {
            Console.WriteLine("No goals listed yet!");
        }

        for (int i = 1; i != goalTracker.Count + 1; i++)
        {
            Console.WriteLine($"{i}. [{(goalTracker[i-1].getIfCompleted() ? "X" : " ")}] {goalTracker[i - 1].getSummaryOfGoal()}");
        }
    }

    public void RecordEvents()
    {
        int count = 1;
        foreach (Goal goal in goalTracker)
        {
            Console.WriteLine($"{count}. [{(goal.getIfCompleted() ? "X" : " ")}] {goal.getSummaryOfGoal()}");
            count++;
        }
        Console.Write("Pick a goal to report on: ");
        try
        {
            int choice = int.Parse(Console.ReadLine());
            string line = goalTracker[choice - 1].getType();
            Console.WriteLine(line);
            if (line == "Checklist Goal")
            {
                IfChoiceACheckList(choice);
            }
            else
            {
                IfNotChoiceACheckList(choice);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void IfNotChoiceACheckList(int c)
    {
        int realChoice = c - 1;
        Console.WriteLine($"You've completed {goalTracker[realChoice].getGoalName()} {goalTracker[realChoice].getShortDescription()} You received {goalTracker[realChoice].getAmountOfPoints()} Points");
        _points += goalTracker[realChoice].getAmountOfPoints();
        goalTracker[realChoice].setIfCompleted();
        SaveGoalsWhenRecordHasBeenUpdated();

    }
    
    public void IfChoiceACheckList(int c)
    {
        Goal chosenGoal = goalTracker[c - 1];

        if (chosenGoal is ChecklistGoal checklistGoal)
        {
            checklistGoal.reduceReps();
            if(checklistGoal.getNumberOfRepsLeft() > 0){
                // _points += checklistGoal.getAmountOfPoints();
            }
            else if (checklistGoal.getNumberOfRepsLeft() == 0)
            {
                _points += checklistGoal.getAmountOfPoints();
                checklistGoal.setIfCompleted();
            }
        }
    }

}