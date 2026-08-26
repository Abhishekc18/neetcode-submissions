public class Singleton {

    private Singleton() {}
    public static Singleton _instance;
    public string Value {get;set;}

    public static Singleton getInstance() {
        if(_instance == null){
            _instance = new Singleton();
        }
        return _instance;
    }

    public string getValue() {
        if(_instance.Value != null){
            return _instance.Value;
        }
        return null;
    }

    public void setValue(string value){
        _instance.Value = value;
    }
}
