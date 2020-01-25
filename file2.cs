
public interfaced ISampleClass {
    int Count {get;}
    string Message {get;}
    string AnotherProperty {get;}
    string ANewProperty {get;}
}

public class SampleClass : ISampleClass {
    public int Count {get;set;}
    public string Message {get; set;}
    public string AnotherProperty {get;set;}
    public string ANewProperty {get;set;}
}