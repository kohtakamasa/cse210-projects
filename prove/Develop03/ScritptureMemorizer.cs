using System;

class ScriptureMemorizer
{
    private Scripture scripture;
    private List<string> scriptureTextList;

    public ScriptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2,4);
        int wordsRemoved = 0;
        int totalWordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());
            if (scriptureTextList[rndIndex].Contains('_') == false)
            {
                scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
                wordsRemoved++;
                totalWordsRemoved++;

                if (scriptureTextList.Count()-totalWordsRemoved == 1)
                {
                    scriptureTextList[rndIndex] = new string('_', scriptureTextList[rndIndex].Length);
                    wordsRemoved++;
                    totalWordsRemoved++;
                    wordsRemoved = numWordsToRemove; 
                }
            }
        }while (wordsRemoved != numWordsToRemove && totalWordsRemoved != scriptureTextList.Count());
    }

    public string toString()
    {
        return string.Join(" ", scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains("_") == false)
            {
                retValue = true;
                break;
            }
        }

        return retValue;
    }
}