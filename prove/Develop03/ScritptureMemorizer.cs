using System;

class ScriptureMemorizer
{
    private Scripture _scripture;
    private List<string> _scriptureTextList;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
        _scriptureTextList = new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        _scriptureTextList = _scripture.toString().Split(" ").ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(3,4);
        int wordsRemoved = 0;
        int totalWordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, _scriptureTextList.Count());
            if (_scriptureTextList[rndIndex].Contains('_') == false)
            {
                _scriptureTextList[rndIndex] = new string('_', _scriptureTextList[rndIndex].Length);
                wordsRemoved++;
                totalWordsRemoved++;
            }
        }while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(" ", _scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retValue = false;

        foreach (string word in _scriptureTextList)
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