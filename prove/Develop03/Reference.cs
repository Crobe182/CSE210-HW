using System;
using System.Dynamic;

class Reference
{
    private string _selectedReference;
    private Dictionary<string, string> _scriptRefs = new Dictionary<string, string>
    {
        {"1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
        {"John 3:16","For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."},
        {"Ether 12:27","And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."},
        {"Ether 12:6","And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."},
        {"Helaman 5:12","And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."},
        {"Proverbs 3:5-6","Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths."}
    }; 

    private string _randomSelectedRef;

    private string _randomSelectedKey;
    
    public Reference()
    {
        SetReferenceAndScripture();
    }


    public void SetReferenceAndScripture()
    {
        Random randomScriptRefKey = new Random();

        List<string> keys = new List<string>(_scriptRefs.Keys);

        int randomIndex = randomScriptRefKey.Next(keys.Count);

        string randomKey = keys[randomIndex];

        _randomSelectedRef = _scriptRefs[randomKey];

        _randomSelectedKey = randomKey;
    }

    private string SetSelectedRef()
    {
        _selectedReference = $"{_randomSelectedKey} : {_randomSelectedRef}";
       return _selectedReference;
    }

    public string GetSelectedRef()
    {
        return _selectedReference;
    }

    public string GetSelectedKey()
    {
        return _randomSelectedKey;
    }

    public string GetSelectedScript()
    {
        return _randomSelectedRef;
    }
}