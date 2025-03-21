public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide){
        Random random = new Random();

        for(int i = 0; i < numberToHide; i++){
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText(){
        string result = _reference.GetDisplayText();
        result = result + " ";
        
        foreach(Word word in _words){
            result = result + word.GetDisplayText();
            result = result + " ";
        }

        return result;

    }

    public bool IsCompletelyHidden(){
        foreach(Word word in _words){
            if(!word.IsHidden()){
                return false;
            }
        }
        return true;
    }
}