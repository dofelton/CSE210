class Reference
{

private string _book;
private int _chapter;
private int _verse;

public Reference()
{
    _book = "2 Nephi";
    _chapter = 2;
    _verse = 25;
}

public string GetBook()
{
    return _book;
}
public void SetBook(string book)
{
    _book = book;
}
public int GetChapter()
{
    return _chapter;
}
public void SetChapter(int chapter)
{
    _chapter = chapter;
}
public int GetVerse()
{
    return _verse;
}
public void SetVerse(int verse)
{
    _verse = verse;
}

public string DisplayReference()
{
    return $"{_book} {_chapter}:{_verse}";
}

}