using System;
using System.Reflection.Metadata.Ecma335;
class Scripture
{
    public string _scripture;
    public List<string> _scriptures = new List<string>() {"Adam fell that men might be; and men are. that they might have joy."};
    public Scripture()
    {
        _scripture = ChooseScripture();
    }
    
    

    public string ChooseScripture()
    {
        return _scriptures[0];
    }

    public string DisplayScripture(string reference, List<string> scripture)
    {
        string script = string.Join( " ", scripture);
        return $"{reference} - {script}";
    }


}